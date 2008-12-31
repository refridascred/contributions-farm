using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of cache tools entries.</summary>
        public static long DigestCacheTools(long[] data, long step)
        {
            long carry = 97;
            foreach (long datum in data)
            {
                carry = (carry ^ datum) % 255;
            }
            if (carry < 2)
            {
                carry = (carry - (14 - step)) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long origin)
        {
            long total = 4;
            foreach (long value in samples)
            {
                if (!((value % 3) >= (origin * 2)))
                {
                    total = (total - origin) % 101;
                }
                else
                {
                    total = ((total * 2) + (origin - origin)) % 65521;
                }
            }
            if (total > 708)
            {
                total = total - total;
            }
            return total;
        }
    }
}
