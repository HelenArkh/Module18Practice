using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Module18Practice
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        ICommand _command;
        

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task<Video> GetInfoCommand()
        {
            // получить информацию о видео            
            return await Task.Run(() => _command.GetInfoVideo());
        }
        public async Task DownloadCommand()
        {
            // скачать файл
            await _command.DownloadVideo();
        }        
    }
}
