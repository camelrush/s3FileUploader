using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

namespace S3FileUploader
{
    class UploadTask 
    {
        public enum eState
        {
            Init,
            Ready,
            Uploaded
        }

        private FileInfo uploadFile;
        private String bucketName;
        private eState state;
        private IAmazonS3 s3Client;

        public eState State
        {
            get { return this.state; }
        }

        public UploadTask(RegionEndpoint RegionEndPoint ,String BucketName ,FileInfo UploadFile)
        {
            this.uploadFile = UploadFile;
            this.bucketName = BucketName;
            this.s3Client = new AmazonS3Client(RegionEndPoint);
            this.state = eState.Init;
        }

        public void Upload()
        {
            this.state = eState.Ready;
            UploadFileAsync().Wait();
            this.state = eState.Uploaded;
        }

        private async Task UploadFileAsync()
        {
            try
            {
                var fileTransferUtility =
                    new TransferUtility(s3Client);

               

                // Option 1. Upload a file. The file name is used as the object key name.
                await fileTransferUtility.UploadAsync(this.uploadFile.FullName, this.bucketName);
                Console.WriteLine("Upload completed : " + this.uploadFile.FullName);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }
        }
    }
}
