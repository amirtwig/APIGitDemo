﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIGitDemo.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        // GET api/values/
        public string GetAll()
        {
            return "value";
        }

        // GET api/values/
        public string GetAll2()
        {
            return "value";
        }

        // GET api/values/
        public string GetAll3()
        {
            return "value";
        }

        // GET api/values/
        public string GetAll4()
        {
            return "value";
        }

        public string SGetAll2()
        {
            return "value";
        }
        public string SGetAll1()
        {
            return "value1+value2+value3+value4";
        }

    }
}
