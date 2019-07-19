using System;

namespace HMT.Web.Api.Tracking.Areas.HelpPage {
    /// <summary>
    /// This represents an image sample on the help page. There's a display template named ImageSample associated with this class.
    /// </summary>
    public class ImageSample {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSample"/> class.
        /// </summary>
        /// <param name="src">The URL of an image.</param>
        public ImageSample(string src) {
            if (src == null) {
                throw new ArgumentNullException("src");
            }
            Src = src;
        }

        /// <summary>
        /// Source
        /// </summary>
        public string Src { get; private set; }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) {
            ImageSample other = obj as ImageSample;
            return other != null && Src == other.Src;
        }

        /// <summary>
        /// Get Has Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() {
            return Src.GetHashCode();
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return Src;
        }
    }
}