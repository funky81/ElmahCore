﻿using System;
using System.Net;
using System.Runtime.Serialization;

namespace ElmahCore
{
	[Serializable]
	internal class HttpException : Exception
	{
		public int StatusCode { get; }


		public HttpException(int statusCode) : base(((HttpStatusCode)statusCode).ToString())
		{
			StatusCode = statusCode;
		}

	}
}