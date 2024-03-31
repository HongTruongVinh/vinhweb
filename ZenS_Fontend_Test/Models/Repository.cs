using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZenS_Fontend_Test.Models
{
    public class Repository
    {
        public List<Joke> Jokes;
        public List<ViewJoke> ViewJokes;

        public Repository() {
            Jokes = new List<Joke>();
            ViewJokes = new List<ViewJoke>();
        }

        public void SaveChanges() { }
    }
}