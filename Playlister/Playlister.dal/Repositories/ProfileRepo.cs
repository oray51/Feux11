using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Playlister.dal;



namespace Playlister.dal.Repositories
{

    public class ProfileRepo : IRepository<Profile>
    {
        private PlaylisterDEV _context = null;

        public ProfileRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Profile getById(Profile playlisterObject)
        {
            return _context.Profile.Find(playlisterObject.Profile_ID);

        }

        public Profile[] getAll()
        {
            return _context.Profile.ToArray();
        }

        public void add(Profile playlisterObject)
        {
            _context.Profile.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Profile playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Profile playlisterObject)
        {
            _context.Profile.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Profile> query(System.Linq.Expressions.Expression<Func<Profile, bool>> filter)
        {
            return _context.Profile.Where(filter);
        }
    }
}