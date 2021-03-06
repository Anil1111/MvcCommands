using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCommands;
using System;

namespace Demo
{
    [RoutedCommand("demo/{id}", "POST", RouteName = "Sample")]
    public class SampleCommand
    {
        [FromRoute]
        public String Id { get; set; }

        [FromQuery]
        public String Query { get; set; }

        [FromBody]
        public SampleBody Body { get; set; }

        [FromHeader(Name="X-Custom-Header")]
        public String XCustomHeader { get; set; }

        public class SampleBody
        {
            public String Value { get; set; }
        }
    }
}