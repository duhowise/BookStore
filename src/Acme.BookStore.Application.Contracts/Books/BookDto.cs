﻿using System;
using Acme.BookStore.Books;
using Volo.Abp.Application.Dtos;

// ReSharper disable once CheckNamespace
namespace Acme.BookStore
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}