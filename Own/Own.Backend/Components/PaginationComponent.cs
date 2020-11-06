using System;
using System.Collections.Generic;
using System.Linq;

namespace Own.Backend.Components
{
    public class PaginationComponent<T>
    where T : class
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public int PageCount { get; set; }
        public int FirstRowOnPage
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
        }
        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * PageSize, RowCount); }
        }
        public string PaginateText
        {
            get { return RowCount == 0 ? "Przedstawiono 0 pozycji" : $"Przedstawiono od {FirstRowOnPage} do {LastRowOnPage} na {RowCount} pozycji"; }
        }
        public List<T> Records { get; set; } = null;

        public PaginationComponent(IQueryable<T> query, int currentPage, int pageSize)
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.RowCount = query.Count();
            this.PageCount = (int)Math.Ceiling((double)RowCount / PageSize);
            this.Records = query.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
        }

        public PaginationComponent(IQueryable<T> query)
        {
            this.CurrentPage = 1;
            this.PageSize = 1;
            this.RowCount = query.Count();
            this.PageCount = 1;
            this.Records = query.ToList();
        }
    }
}
