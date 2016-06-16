﻿//-----------------------------------------------------------------------
// <copyright company="Metamorphic">
// Copyright (c) Metamorphic. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Metamorphic.Core.Actions;
using Metamorphic.Server.Properties;

namespace Metamorphic.Server.Actions
{
    internal sealed class ActionStorage : IStoreActions
    {
        /// <summary>
        /// The collection of known actions.
        /// </summary>
        private readonly Dictionary<ActionId, ActionDefinition> _actions = new Dictionary<ActionId, ActionDefinition>();

        /// <summary>
        /// Returns the <see cref="ActionDefinition"/> which the given <see cref="ActionId"/>.
        /// </summary>
        /// <param name="action">The ID of the action</param>
        /// <returns>The action definition with the given ID.</returns>
        public ActionDefinition Action(ActionId action)
        {
            if (!HasActionFor(action))
            {
                return null;
            }

            return _actions[action];
        }

        /// <summary>
        /// Adds a new <see cref="ActionDefinition"/> to the collection.
        /// </summary>
        /// <param name="definition">The action definition that should be added.</param>
        public void Add(ActionDefinition definition)
        {
            {
                Lokad.Enforce.Argument(() => definition);
                Lokad.Enforce.With<DuplicateActionDefinitionException>(
                    !HasActionFor(definition.Id),
                    Resources.Exceptions_Messages_DuplicateActionDefinition);
            }

            _actions.Add(definition.Id, definition);
        }

        /// <summary>
        /// Returns a value indicating whether the storage has an <see cref="ActionDefinition"/>
        /// with the given <see cref="ActionId"/>.
        /// </summary>
        /// <param name="action">The ID of the action.</param>
        /// <returns>
        ///   <see langword="true" /> if the current rule applies to the given signal; otherwise, <see langword="false" />.
        /// </returns>
        [SuppressMessage(
            "Microsoft.StyleCop.CSharp.DocumentationRules",
            "SA1628:DocumentationTextMustBeginWithACapitalLetter",
            Justification = "Documentation can start with a language keyword")]
        public bool HasActionFor(ActionId action)
        {
            if (action == null)
            {
                return false;
            }

            return _actions.ContainsKey(action);
        }
    }
}
