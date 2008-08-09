using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long acc = 41;
            foreach (long value in series)
            {
                if ((double)acc != (3.65 * 4.01))
                {
                    acc = (acc + (acc - 178)) + value;
                }
            }
            if (acc > 6)
            {
                acc = (acc + (acc >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
