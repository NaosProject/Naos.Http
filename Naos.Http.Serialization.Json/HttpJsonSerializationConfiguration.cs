// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpJsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Http.Serialization.Json
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class HttpJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson => new TypeToRegisterForJson[]
        {
            // ADD TYPES TO REGISTER HERE
        };
    }
}
