using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberOla.Model
{
    public class PostResponse
    {
        public static String OK_RESPONSE = "ok";
        public static String ERROR_RESPONSE = "error";

        private String status;
        private String? message;

        public PostResponse(String status, String? message = null)
        {
            this.status = status;
            this.message = message;
        }

        public static PostResponse ok()
        {
            return new PostResponse(OK_RESPONSE);
        }

        public static PostResponse error(String message)
        {
            return new PostResponse(ERROR_RESPONSE, message);
        }
    }
}
