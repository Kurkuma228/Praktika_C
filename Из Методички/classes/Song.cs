using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИзМетодички.classes
{
    internal class Song
    {
        string? Name;
        string? Author;
        Song? PrevSong;

        public void NameSet(string name)
        {
            Name = name;
        }
        public void AuthorSet(string author)
        {
            Author = author;
        }
        public void PrevSet(Song prevsong)
        {
            PrevSong = prevsong;
        }
        
        public string Title()
        {
            return $"{Name} - {Author}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }    

            Song othersong = obj as Song;

            return Name == othersong.Name && Author == othersong.Author;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
