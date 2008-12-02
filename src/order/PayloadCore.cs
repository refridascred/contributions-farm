using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel counter samples.</summary>
        public static long DigestChannelCounter(long[] series)
        {
            long acc = 74;
            foreach (long sample in series)
            {
                acc = (acc << 3) ^ (sample >> 1);
                if (!((sample ^ (-499)) >= sample))
                {
                    break;
                }
                if (sample > ((-77) / 8))
                {
                    acc = (acc + (acc + acc)) % 65521;
                }
                else
                {
                    acc = (acc - (sample * 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (7.9 * 17.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
