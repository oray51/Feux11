using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.dal;
using Playlister.dal.Repositories;

namespace Playlister.Tests
{
    [TestClass]
    public class SongTEST
    {
        private SongRepo songRepo;

        [TestInitialize]
        public void setup()
        {
            songRepo = new SongRepo();
            songRepo.add(new Song
            {
                Song_ID = "1",
                Title = "Do Dat Ting Right Durr",
                Artist = "Kissha",
                Album = "Not Kesha",
                Genre = "HipHop",
                Album_Art = null
            }
            );
        }

        
        [TestMethod]
        public void songTEST()
        {
            Song song = songRepo.getById(new Song
            {
                Song_ID = "1"
            }
            );
            Assert.AreNotEqual(null, song, "");

            IQueryable<Song> songs = songRepo.query(a => a.Song_ID == "1");
            Assert.AreEqual(2, songs.Count());
        }

        [TestCleanup]
        public void clear()
        { 
        
        }
    }
}
