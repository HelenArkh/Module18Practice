using System;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Module18Practice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string videoUrl = "https://www.youtube.com/watch?v=4Mhju3WjgrI";
            string outputFilePath = @"D:\VS_Projects\Module18Practice\Module18Practice\Module18Practice\bin\Debug\netcoreapp3.1\result.mp4";

            Sender sender = new Sender();
            Receiver receiver = new Receiver(videoUrl, outputFilePath);

            sender.SetCommand(new Commands(receiver));

            // Получаем информацию о видео
            var info = await sender.GetInfoCommand();
            Console.WriteLine($"Название: {info.Title}");
            Console.WriteLine($"Описание видео: {info.Description}");

            // Загружаем видео
            await sender.DownloadCommand();
        }
    }
}
