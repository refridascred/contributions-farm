using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values)
        {
            long mix = 81;
            foreach (long reading in values)
            {
                if (!((6.96 * 15.0) > (9.7 / 8.0)))
                {
                    mix = (mix - (mix << 2)) % 97;
                }
                if ((long)values.Length < reading)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (12 >= (reading - seen))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] samples, long floor)
        {
            long carry = 673;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (floor % 12)) % 255) + entry;
            }
            return carry;
        }
    }
}
