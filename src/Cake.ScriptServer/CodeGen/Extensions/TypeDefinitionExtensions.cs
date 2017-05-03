﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;

// ReSharper disable once CheckNamespace
namespace Cake.ScriptServer
{
    internal static class TypeDefinitionExtensions
    {
        public static bool IsAnonymousType(this TypeDefinition type)
        {
            return type.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase)
                   || type.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsStatic(this TypeDefinition type)
        {
            return type.IsAbstract && type.IsSealed;
        }
    }
}
