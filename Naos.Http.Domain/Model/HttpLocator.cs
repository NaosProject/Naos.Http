// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpLocator.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Http.Domain
{
    using System;
    using Naos.Service.Domain;

    /// <summary>
    /// Http implementation of the <see cref="ServiceLocatorBase"/>.
    /// </summary>
    public partial class HttpLocator : ServiceLocatorBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpLocator"/> class.
        /// </summary>
        /// <param name="uri">The base URI.</param>
        public HttpLocator(
            Uri uri)
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Gets the base URI.
        /// </summary>
        /// <value>The base URI.</value>
        public Uri Uri { get; private set; }
    }
}
