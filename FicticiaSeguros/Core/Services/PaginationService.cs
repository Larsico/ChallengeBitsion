﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FicticiaSeguros.Core.Services
{
    public class PaginationService<T> : List<T>
    {

        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginationService(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginationService<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize, int counter)
        {
            var count = counter; //await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginationService<T>(items, count, pageIndex, pageSize);
        }



    }
}
