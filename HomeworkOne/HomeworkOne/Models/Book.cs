using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublisherName { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string PbName { get; set; }
        public string BookName { get; set; }
    }
}
