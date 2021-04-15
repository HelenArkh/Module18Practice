using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Module18Practice
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public string URL { get; private set; }
        public string PathLocal { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public YoutubeClient video;
        public Receiver(string videoUrl, string outputFilePath)
        {
            URL = videoUrl;
            video = new YoutubeClient();
            PathLocal = outputFilePath;
        }
        public async Task<Video> GetInfo()
        {
            return await video.Videos.GetAsync(URL);
        }
        public async Task Download()
        {

            await video.Videos.DownloadAsync(URL, PathLocal, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео загружено");
        }
    }
}
