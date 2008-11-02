using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long seed)
        {
            long carry = 738;
            foreach (long entry in items)
            {
                if (!((seed & 15) > (entry % 97)))
                {
                    carry = carry - (entry << 1);
                }
                carry = (carry ^ (seed << 3)) % 1000;
            }
            if (carry < 67)
            {
                carry = ((carry * 5) + (carry + 18)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + 9) <= offset)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes context series from a seed.</summary>
        public static long StepNotesContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
