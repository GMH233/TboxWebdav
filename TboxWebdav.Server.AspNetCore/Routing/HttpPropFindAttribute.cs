﻿using Microsoft.AspNetCore.Mvc.Routing;
using System.Diagnostics.CodeAnalysis;

namespace TboxWebdav.Server.AspNetCore.Routing
{
    /// <summary>
    /// The WebDAV HTTP PROPFIND method
    /// </summary>
    public class HttpPropFindAttribute : HttpMethodAttribute
    {
        private static readonly IEnumerable<string> _supportedMethods = new[] { "PROPFIND" };

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpPropFindAttribute"/> class.
        /// </summary>
        public HttpPropFindAttribute()
            : base(_supportedMethods)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpPropFindAttribute"/> class.
        /// </summary>
        /// <param name="template">The route template. May not be null.</param>
        public HttpPropFindAttribute([NotNull] string template)
            : base(_supportedMethods, template)
        {
            if (template == null)
                throw new ArgumentNullException(nameof(template));
        }
    }
}
