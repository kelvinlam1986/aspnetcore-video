using System.Collections.Generic;
using System.Linq;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {
        private IEnumerable<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "A", Genre = Genres.Action },
                new Video { Id = 2, Title = "B", Genre = Genres.Animated },
                new Video { Id = 3, Title = "C", Genre = Genres.Comedy }
            };
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
