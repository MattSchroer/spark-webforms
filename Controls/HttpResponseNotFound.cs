﻿namespace Spark.WebForms.Controls
{
	/// <summary>
	/// A Rendering that sets the status of the response to "404: Not Found".
	/// </summary>
	public class HttpResponseNotFound : HttpResponseStatus
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HttpResponseNotFound"/> class.
		/// </summary>
		public HttpResponseNotFound()
			: base()
		{
			this.StatusCode = 404;
			this.StatusDescription = "Page not found";
		}
	}
}
