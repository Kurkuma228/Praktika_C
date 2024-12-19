using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИзМетодички.classes
{
    internal class Song
    {
        string name;
        string author;
        Song prevSong;
        
        public Song() { }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            prevSong = null;
        }
        public Song(string name, string author, Song prevSong)
        {
            this.name = name;
            this.author = author;
            this.prevSong = prevSong;
        }

        public string Title()
        {
            return $"{name} - {author}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }    

            Song othersong = obj as Song;

            return obj == othersong;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
