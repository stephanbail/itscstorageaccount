using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace AzureBlobStorageDemo
{
    class Program
    {
        private const string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=theaccountname;AccountKey=fkExxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx==;EndpointSuffix=core.windows.net";
        private const string ContainerName = "backup";
        private const string FileName = "storageaccount.jpeg";

        static async Task Main(string[] args)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(ConnectionString);

            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);

            await containerClient.CreateIfNotExistsAsync();

            BlobClient blobClient = containerClient.GetBlobClient(FileName);

            Console.WriteLine("Uploading file to Blob storage");

            using FileStream fileStream = new FileStream(FileName, FileMode.Open);
            await blobClient.UploadAsync(fileStream, true);

            Console.WriteLine("File uploaded successfully");

            Console.WriteLine("Downloading file from Blob storage");

            BlobDownloadInfo download = await blobClient.DownloadAsync();

            using FileStream downloadFileStream = new FileStream("downloaded-" + FileName, FileMode.Create);

            await download.Content.CopyToAsync(downloadFileStream);

            Console.WriteLine("File downloaded successfully");

            Console.ReadLine();
        }
    }
}
