﻿//===================================================
// Copyright (c)  coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Pease
//===================================================

using System;

namespace Sheenam.Api.Models.Foundations.HomeRequests
{
    public class HomeRequests
    {
        public Guid Id { get; set; }
        public Guid GuestId { get; set; }
        public Guid HomeId { get; set; }
        public string Message { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
