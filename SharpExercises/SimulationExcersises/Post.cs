using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExercises.SimulationExcersises
{
    /// <summary>
    /// Class that simulates a post voting system
    /// </summary>
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _votes;

        /// <summary>
        /// Constructor that creates a post with a title and a description
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _created = DateTime.Now;
            _votes = 0;
        }

        /// <summary>
        /// Method that incriases the votes of the current post
        /// </summary>
        public void UpVote()
        {
            _votes++;
        }

        /// <summary>
        /// Method that decriases the votes of the current post
        /// </summary>
        public void DownVote()
        {
            _votes--;
        }

        /// <summary>
        /// Method that displays in console the post information (title, description, created date and votes)
        /// </summary>
        public void DisplayPost()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Created: {_created}");
            Console.WriteLine($"Votes: {_votes}");
        }

    }
}
