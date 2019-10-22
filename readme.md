# S3経由RDSへのファイルアップロード(マルチスレッド)
-----
- S3へのファイルアップロードをトリガにしてRDS(MySQL)へデータをINSERTする、以下のlambda関数を作成した。
- S3に対してマルチスレッド(100 worker thread)で1,000件をアップロードした場合、接続コネクションエラーが発生することを確認する。

```
var mysql = require('mysql');
const SDK = require('aws-sdk');
SDK.config.region = 'ap-northeast-1';
const S3 = new SDK.S3;

exports.handler = function(event,context){

    let s3GetParams = {
        Bucket: event.Records[0].s3.bucket.name,
        Key: event.Records[0].s3.object.key
    };
    
    S3.getObject(s3GetParams , function(err ,data){

      var connection = mysql.createConnection({
        host     : 'database-1.**************.ap-northeast-1.rds.amazonaws.com', //RDSのエンドポイント
        user     : 'admin', //MySQLのユーザ名
        password : '*******', //MySQLのパスワード
        database : 'testdb'
      });
  
      connection.connect();

      let fname = event.Records[0].s3.object.key + '_' + context.awsRequestId;
      let aryData = data.Body.toString().replace('\r\n','').split(',');
      console.log(aryData);
      let sqlString = "insert into table1 values ('" + fname  + "','" + aryData[0] + "','" + aryData[1] + "','" + aryData[2] + "')"
      console.log(sqlString);
      
      connection.query(sqlString, function(err, rows, fields) {
        if (err) throw err;
        console.log('insert success.');
      });
  
      connection.end(function(err) {
          context.done();
      });

    });
}

```
- 実行した結果、問題なく 1,000件のレコードが登録された。
