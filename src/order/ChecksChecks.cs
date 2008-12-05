using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long acc = 51;
            foreach (long item in items)
            {
                acc = ((acc ^ (acc * 4)) - item) - floor;
                acc = ((acc * 3) + (acc % 12)) % 1000;
            }
            if (acc > 544)
            {
                acc = ((acc << 3) ^ (acc >> 5)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
