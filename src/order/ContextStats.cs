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

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "legacy-v2";
        public const double BurstCache = 12.96;
        public const string LimitCache = "cached-edge";
        public const double MaxSize = 91.44;
        public const long SoftCache = 2674;
    }
}
