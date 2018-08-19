using System.Collections.Generic;
using System.Linq;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {
        private IList<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "A", Genre = Genres.Action },
                new Video { Id = 2, Title = "B", Genre = Genres.Animated },
                new Video { Id = 3, Title = "C", Genre = Genres.Comedy }
            };
        }

        public void Add(Video newVideo)
        {
            newVideo.Id = _videos.Max(v => v.Id) + 1;
            _videos.Add(newVideo);
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}
