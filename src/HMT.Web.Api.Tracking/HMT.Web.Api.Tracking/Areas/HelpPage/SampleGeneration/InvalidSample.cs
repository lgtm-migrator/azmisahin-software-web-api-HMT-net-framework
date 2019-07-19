using System;

namespace HMT.Web.Api.Tracking.Areas.HelpPage {
    /// <summary>
    /// This represents an invalid sample on the help page. There's a display template named InvalidSample associated with this class.
    /// </summary>
    public class InvalidSample {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessage"></param>
        public InvalidSample(string errorMessage) {
            if (errorMessage == null) {
                throw new ArgumentNullException("errorMessage");
            }
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Error Message
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) {
            InvalidSample other = obj as InvalidSample;
            return other != null && ErrorMessage == other.ErrorMessage;
        }

        /// <summary>
        /// Get Has Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() {
            return ErrorMessage.GetHashCode();
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return ErrorMessage;
        }
    }
}