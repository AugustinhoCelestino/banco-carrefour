﻿namespace Domain.Models.Requests
{
    public class GetDailyCashEntriesResquest
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string OrderBy { get; set; } = string.Empty;
    }
}
