using System.Collections.Generic;
using System.Linq;

namespace GenericsExample
{
    public class DVDPager
    {
        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; } = 5;
        public List<DVD> AllRecords { get; set; }
        public List<DVD> GetCurrentPage()
        {
            var skipAmount = CurrentPage * RecordsPerPage;
            return AllRecords.Skip(skipAmount).Take(RecordsPerPage).ToList();
        }
        public List<DVD> GetPreviousPage()
        {
            CurrentPage--;
            return GetCurrentPage();
        }
        public List<DVD> GetNextPage()
        {
            CurrentPage++;
            return GetCurrentPage();
        }
    }
}