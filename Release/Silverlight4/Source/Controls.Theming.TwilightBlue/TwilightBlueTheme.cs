﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;

namespace System.Windows.Controls.Theming
{
    /// <summary>
    /// Implicitly applies the Twilight Blue theme to all of its descendent
    /// FrameworkElements.
    /// </summary>
    /// <QualityBand>Preview</QualityBand>
    public partial class TwilightBlueTheme : Theme
    {
        /// <summary>
        /// Stores a reference to a Uri referring to the theme resource for the class.
        /// </summary>
        private static Uri ThemeResourceUri = new Uri("/System.Windows.Controls.Theming.TwilightBlue;component/Theme.xaml", UriKind.Relative);

        /// <summary>
        /// Initializes a new instance of the TwilightBlueTheme class.
        /// </summary>
        public TwilightBlueTheme()
            : base(ThemeResourceUri)
        {
        }

        /// <summary>
        /// Gets a value indicating whether this theme is the application theme.
        /// </summary>
        /// <param name="app">Application instance.</param>
        /// <returns>True if this theme is the application theme.</returns>
        public static bool GetIsApplicationTheme(Application app)
        {
            return GetApplicationThemeUri(app) == ThemeResourceUri;
        }

        /// <summary>
        /// Sets a value indicating whether this theme is the application theme.
        /// </summary>
        /// <param name="app">Application instance.</param>
        /// <param name="value">True if this theme should be the application theme.</param>
        public static void SetIsApplicationTheme(Application app, bool value)
        {
            SetApplicationThemeUri(app, ThemeResourceUri);
        }
    }
}