namespace Rhythm.Html
{

    // Namespaces.
    using System.Web.Mvc;

    /// <summary>
    /// Extension methods for BEM naming.
    /// </summary>
    public static class BemExtensions
    {

        #region Extension Methods

        /// <summary>
        /// Suffixes a string to a widget name.
        /// </summary>
        /// <param name="htmlHelper">
        /// The HTML helper to add this extension method to.
        /// </param>
        /// <param name="toAppend">
        /// The string to append.
        /// </param>
        /// <returns>
        /// The BEM-appropriate name (e.g., "callout__header").
        /// </returns>
        public static string Bem(this HtmlHelper htmlHelper, string toAppend = "")
        {
            var widget = htmlHelper.ViewData.Model as dynamic;
            var className = widget.GetClassName() as string;
            return $"{className}{toAppend}";
        }

        #endregion

    }

}