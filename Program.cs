using System;
using System.IO;
using Amazon.Glacier;
using Amazon.Glacier.Transfer;
using Amazon.Runtime;
using GlacierApp;
using System.Text.Json;

class ArchiveDeleteHighLevel
{
    static string JsonFile = "output.json";

    public static void Main(string[] args)
    {
        string aws_access_key_id = args[0];
        string aws_secret_access_key = args[1];
        string vaultName = args[2];

        string jsonString = File.ReadAllText(JsonFile);
        Response response = JsonSerializer.Deserialize<Response>(jsonString);
        var Region = Amazon.RegionEndpoint.USEast1;

        foreach (var item in response.ArchiveList)
        {
            try
            {
                var manager = new ArchiveTransferManager(aws_access_key_id, aws_secret_access_key, Region);
                manager.DeleteArchive(vaultName, item.ArchiveId);
                Console.WriteLine("Archive {0} processed", item.ArchiveId);
            }
            catch (AmazonGlacierException e) { Console.WriteLine(e.Message); }
            catch (AmazonServiceException e) { Console.WriteLine(e.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        Console.WriteLine("To continue, press Enter");
        Console.ReadKey();
    }
}
