using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsExample
{

    class VideoEventArgs:EventArgs
    {
        public Video Video { get; set; }
    }
    class VideoEncoder
    {

        // 1. Define a delegate who's sign is same as of subscriber's event function
        //2. Event based on delegate
        //3. publish/raise event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); //1


        //EventHandler<TEventArgs> or EventHandler

        // Example- public EventHandler<VideoEventArgs> -- if we use this, we get rid of delegate declaration explicitly done in step 1

        public event VideoEncodedEventHandler VideoEncoded; //2
        public void Encode(Video video) {

            Console.WriteLine("Video Encoding");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video) //Event publisher methods should be protected, virtual and void and naming should start from "On"
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video=video}); //current class, sends no data
            }
        }

    }
}
