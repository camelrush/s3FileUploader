using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace S3FileUploader
{
    class TaskManager
    {
        private static readonly int DEFAULT_MAX_THREAD = 5;

        private List<UploadTask> uploadList;
        private int maxThread;
        private RegionEndpoint regionEndPoint;
        private String bucketName;

        public int MaxThread
        {
            get { return this.maxThread; }
            set { this.maxThread = value; }
        }

        public TaskManager(String RegionEndPointName ,String BucketName)
        {
            Init();
            this.regionEndPoint = RegionEndpoint.GetBySystemName(RegionEndPointName);
            this.bucketName = BucketName;
        }

        public void Init()
        {
            this.uploadList = new List<UploadTask>();
            this.maxThread = DEFAULT_MAX_THREAD;
        }

        public void Add(FileInfo UploadFile)
        {
            UploadTask task = new UploadTask(this.regionEndPoint ,this.bucketName ,UploadFile);
            this.uploadList.Add(task);
        }

        public void Run()
        {
            Parallel.ForEach(this.uploadList, new ParallelOptions{ MaxDegreeOfParallelism = this.maxThread },(task) =>
                {
                    task.Upload();
                });
        }

        private long GetCount(UploadTask.eState State)
        {
            long count = 0;

            foreach (UploadTask task in uploadList)
            {
                if (task.State == State) count++;
            }

            return count;
        }
    }
}
