﻿using System;
namespace PassoutASP.Models
{
    public class ResponseMessage
    {
        public string Type { get; set; }
        public string Message { get; set; }
    }

    public class ResponseType
    {
        public const string ERROR = "error";
        public const string SUCCESS = "success";
    }
}
