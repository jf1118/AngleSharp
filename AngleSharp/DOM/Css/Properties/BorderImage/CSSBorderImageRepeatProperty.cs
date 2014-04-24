﻿namespace AngleSharp.DOM.Css.Properties
{
    using System;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/border-image-repeat
    /// </summary>
    public sealed class CSSBorderImageRepeatProperty : CSSProperty
    {
        #region Fields

        #endregion

        #region ctor

        internal CSSBorderImageRepeatProperty()
            : base(PropertyNames.BorderImageRepeat)
        {
            _inherited = false;
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        protected override Boolean IsValid(CSSValue value)
        {
            if (value != CSSValue.Inherit)
                return false;

            return true;
        }

        #endregion
    }
}
