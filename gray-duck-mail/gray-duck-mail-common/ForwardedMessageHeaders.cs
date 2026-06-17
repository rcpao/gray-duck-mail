using System.Collections.Generic;

namespace GrayDuckMail.Common
{
    /// <summary> From, To, and forwarding metadata captured from a member-forwarded message. </summary>
    public class ForwardedMessageHeaders
    {
        /// <summary> Gets or sets the original sender. </summary>
        /// <value> The original sender. </value>
        public ForwardedMailboxEntry From { get; set; }

        /// <summary> Gets or sets the message recipients. </summary>
        /// <value> The recipients. </value>
        public List<ForwardedMailboxEntry> To { get; set; } = new List<ForwardedMailboxEntry>();

        /// <summary> Gets or sets the forwarding mailboxes after the original sender. </summary>
        /// <value> The forwarding mailboxes. </value>
        public List<ForwardedMailboxEntry> ForwardedBy { get; set; } = new List<ForwardedMailboxEntry>();
    }
}
