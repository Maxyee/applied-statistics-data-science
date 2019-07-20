using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spondon.Models
{
    public class ResponseModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public ResponseModel()
        {
            Success = false;
            Message = string.Empty;
        }

        public void CreateSuccessResponse(T data, string message)
        {
            Message = message;
            Data = data;            
            Success = true;
        }

        public ResponseModel<T> ValidateResponse()
        {
            this.Data = ValidateDataProperty(this.Data);
            return this;
        }

        private T ValidateDataProperty(T Data)
        {
            if (Data == null)
            {
                Data = (T)(object)string.Empty;
            }
            return Data;
        }
    }
}
