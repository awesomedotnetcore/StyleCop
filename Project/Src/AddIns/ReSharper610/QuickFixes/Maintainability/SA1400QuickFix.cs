﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SA1400QuickFix.cs" company="http://stylecop.codeplex.com">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
// <summary>
//   QuickFi for StyleCop Rule SA1400.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StyleCop.ReSharper610.QuickFixes.Maintainability
{
    #region Using Directives

    using System.Collections.Generic;

    using JetBrains.ReSharper.Feature.Services.Bulbs;

    using StyleCop.ReSharper610.BulbItems.Maintainability;
    using StyleCop.ReSharper610.QuickFixes.Framework;
    using StyleCop.ReSharper610.Violations;

    #endregion

    /// <summary>
    /// QuickFi for StyleCop Rule SA1400.
    /// </summary>
    [ShowQuickFix]
    [QuickFix]
    public class SA1400QuickFix : QuickFixBase
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the SA1400QuickFix class that can 
        /// handle <see cref="StyleCopViolationError"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopViolationError"/>that has been detected.
        /// </param>
        public SA1400QuickFix(StyleCopViolationError highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1400QuickFix class that can handle
        /// <see cref="StyleCopViolationHint"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopViolationHint"/>that has been detected.
        /// </param>
        public SA1400QuickFix(StyleCopViolationHint highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1400QuickFix class that can handle
        /// <see cref="StyleCopViolationInfo"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopViolationInfo"/>that has been detected.
        /// </param>
        public SA1400QuickFix(StyleCopViolationInfo highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1400QuickFix class that can handle
        /// <see cref="StyleCopViolationSuggestion"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopViolationSuggestion"/>that has been detected.
        /// </param>
        public SA1400QuickFix(StyleCopViolationSuggestion highlight)
            : base(highlight)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SA1400QuickFix class that can handle
        /// <see cref="StyleCopViolationWarning"/>.
        /// </summary>
        /// <param name="highlight">
        /// <see cref="StyleCopViolationWarning"/>that has been detected.
        /// </param>
        public SA1400QuickFix(StyleCopViolationWarning highlight)
            : base(highlight)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialises the QuickFix with all the available BulbItems that can fix the current
        /// StyleCop Violation.
        /// </summary>
        protected override void InitialiseBulbItems()
        {
            this.BulbItems = new List<IBulbItem>
                {
                    new SA1400AccessModifierMustBeDeclaredBulbItem { Modifier = "public", DocumentRange = this.Violation.DocumentRange, Description = "Make Public : " + this.Violation.ToolTip },
                    new SA1400AccessModifierMustBeDeclaredBulbItem { Modifier = "private", DocumentRange = this.Violation.DocumentRange, Description = "Make Private : " + this.Violation.ToolTip },
                    new SA1400AccessModifierMustBeDeclaredBulbItem { Modifier = "protected", DocumentRange = this.Violation.DocumentRange, Description = "Make Protected : " + this.Violation.ToolTip },
                    new SA1400AccessModifierMustBeDeclaredBulbItem { Modifier = "internal", DocumentRange = this.Violation.DocumentRange, Description = "Make Internal : " + this.Violation.ToolTip },
                };
        }

        #endregion
    }
}