﻿
using System.Text.Json;

namespace MoviesAPITask.Models
{
    public class ResponseModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() =>

            JsonSerializer.Serialize(this);


    }
}
