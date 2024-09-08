using System;

namespace BizHawk.Client.Common.Api.Public
{
	public class ApiError : Exception
	{
		public ApiError(string message = null) : base(message) { }
	}
}
