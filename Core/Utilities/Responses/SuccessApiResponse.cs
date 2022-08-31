﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Responses
{
    public class SuccessApiResponse:ApiResponse
    {
        public SuccessApiResponse() : base(success: true)
        {

        }
        public SuccessApiResponse(string message) : base(success: true, message: message)
        {

        }
    }
}
