namespace Lloyd.AzureMailGateway.Models
{
    /// <summary>
    /// Contains the subject of the E-Mail.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Gets the subject text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class.
        /// </summary>
        /// <param name="text">The text to be used as the subject.</param>
        public Subject(string text) => Text = text;
    }
}
