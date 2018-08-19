using System;
using System.Collections.Generic;
using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Services
{
    public class SqlVideoData : IVideoData
    {
        private VideoDbContext _db;

        public SqlVideoData(VideoDbContext db)
        {
            this._db = db;
        }

        public void Add(Video newVideo)
        {
            this._db.Add(newVideo);
            this._db.SaveChanges();
        }

        public Video Get(int id)
        {
            return _db.Find<Video>(id);
        }

        public IEnumerable<Video> GetAll()
        {
            return _db.Videos;
        }
    }
}
