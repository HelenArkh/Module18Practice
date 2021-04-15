using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Module18Practice
{
    /// <summary>
    /// Базовый интерфейс команд
    /// </summary>
    interface ICommand
    {
        Task<Video> GetInfoVideo();
        Task DownloadVideo();
 
    }
}
