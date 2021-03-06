﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceDummyFactory.designer.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package Naos.Build.Conventions.VisualStudioProjectTemplates.Domain.Test (1.55.38)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Domain.Test
{
    using System;

    using FakeItEasy;

    /// <summary>
    /// DO NOT EDIT.  
    /// THIS CLASS EXISTS SO THAT THE DUMMY FACTORY CAN INHERIT FROM IT AND THE PROJECT CAN COMPILE.
    /// THIS WILL BE REPLACED BY A CODE GENERATED DEFAULT DUMMY FACTORY.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.Build.Conventions.VisualStudioProjectTemplates.Domain.Test", "1.55.38")]
#if !NaosServiceSolution
    internal
#else
    public
#endif
    abstract class DefaultServiceDummyFactory : IDummyFactory
    {
        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}
