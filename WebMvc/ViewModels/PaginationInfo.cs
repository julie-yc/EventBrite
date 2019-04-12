﻿namespace WebMvc.ViewModels
{
    public class PaginationInfo
    {
        public long TotalItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int ActualPage { get; set; }

        public long TotalPages { get; set; }

        public string Previous { get; set; }

        public string Next { get; set; }

    }
}