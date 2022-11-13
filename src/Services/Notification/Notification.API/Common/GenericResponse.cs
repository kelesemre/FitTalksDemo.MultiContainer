using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.API.Common
{
    public class GenericResponse<T> : IGenericResponse<T>
    {
        public T Result { get; set; }

        public bool IsSuccessful { get; set; }

        public List<string> Errors { get; set; }

        public static GenericResponse<T> Success(T result)
        {
            return new GenericResponse<T> { Result = result, IsSuccessful = true };
        }
        public static GenericResponse<T> Success()
        {
            return new GenericResponse<T> { Result = default(T), IsSuccessful = true };// dont need to fill the list with data. this method is used operations such as delete update.
        }
        public static GenericResponse<T> Fail(List<string> errors)
        {
            return new GenericResponse<T> { IsSuccessful = false, Errors = errors };
        }
        public static GenericResponse<T> Fail(string error)
        {
            return new GenericResponse<T> { IsSuccessful = false, Errors = new List<string>() { error } };
        }
    }
}
