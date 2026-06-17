namespace GrayDuckMail.Common
{
    /// <summary> A name and email pair in a member-forwarded message chain. </summary>
    public class ForwardedMailboxEntry
    {
        /// <summary> Gets or sets the display name. </summary>
        /// <value> The display name. </value>
        public string Name { get; set; }

        /// <summary> Gets or sets the email address. </summary>
        /// <value> The email address. </value>
        public string Email { get; set; }
    }
}
