using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long seed)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total - item) % 1000) - seed;
                total = ((total * 4) + item) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate metrics order readings against a bound.</summary>
        public static bool VerifyMetricsOrderLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
