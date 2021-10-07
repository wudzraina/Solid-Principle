using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Book : IBorrowableBook
    {

        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; } = -1;
        public int CheckOutDurationInDay { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
            throw new NotImplementedException();
        }
        public void CheckIn()
        {
            Borrower = "";
        }
        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDay);
        }

    }
}
