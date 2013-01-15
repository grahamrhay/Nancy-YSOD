using System;
using Nancy;

namespace NancyYSOD
{
    public class BadModule : NancyModule
    {
        public BadModule()
        {
            Get["/"] = o => { throw new Exception("something bad"); };
        }
    }
}