﻿using Flogging.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FloggingAPI.Controllers
{
  public class ErrorController : ApiController
  {
    public void Write([FromBody]FlogDetail logEntry)
    {
      Flogger.WriteError(logEntry);
    }

  }
}
