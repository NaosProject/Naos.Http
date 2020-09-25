// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Http.Serialization.Bson
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class HttpBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new TypeToRegisterForBson[]
        {
            // ADD TYPES TO REGISTER HERE
        };
    }
}
