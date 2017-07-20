using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
namespace Program
{
    public class OCRConvertor
    {
        public async void ConverToText(byte[] imageBytes)
        {

            string apikey = "helloworld";

            string ocrText = "";

            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(1, 1, 1);

            MultipartFormDataContent request = new MultipartFormDataContent();
            request.Add(new StringContent(apikey), "apikey");
            request.Add(new StringContent("eng"), "language");

            request.Add(new ByteArrayContent(imageBytes, 0, imageBytes.Length), "image", "image.jpg");

            HttpResponseMessage response = await httpClient.PostAsync("https://api.ocr.space/Parse/Image", request);

            string result = await response.Content.ReadAsStringAsync();

            OCRRoot ocrResult = JsonConvert.DeserializeObject<OCRRoot>(result);

            if (ocrResult.OCRExitCode == 1)
            {
                int count = ocrResult.ParsedResults.Length;
                for (int i = 0; i < count; i++)
                {
                    ocrText = ocrText + ocrResult.ParsedResults[i].ParsedText;
                }
            }
            else
            {
                ocrText = "Error" + result;
            }

            if (!File.Exists(("./file.txt")))
            {
                using (StreamWriter sw = File.CreateText("./file.txt"))
                {
                    sw.WriteLine(ocrText);
                    sw.Close();
                }
            }

            using (StreamWriter sw = File.AppendText("./file.txt"))
            {
                sw.WriteLine(ocrText);
                sw.Close();
            }


        }
    }
}