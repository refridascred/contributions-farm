using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - item) > (tally - 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if ((total - total) == (total * 2))
                {
                    total = (total ^ (entry * 4)) % 255;
                }
            }
            if (total > (-578))
            {
                total = (total * 2) + (seed % 64);
            }
            return total;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
