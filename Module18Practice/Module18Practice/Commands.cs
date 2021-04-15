using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace Module18Practice
{
    /// <summary>
    /// Реализация команд
    /// </summary>
    class Commands : ICommand
    {
        private Receiver receiver;
        public Commands(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public async Task<Video> GetInfoVideo()
        {

            var task = receiver.GetInfo();
            return await task;
        }
        public async Task DownloadVideo()
        {
            await Task.Run(() => receiver.Download());
        }
    }
}
