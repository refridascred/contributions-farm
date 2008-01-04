using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long target)
        {
            if (!((limit ^ 59) == ((-59) << 2)))
            {
                return 6;
            }
            else
            {
                if (((14.0 * 9.88) < (double)target) && ((target & 255) > (722 - 789)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long bound)
        {
            long acc = 93;
            foreach (long sample in series)
            {
                acc = ((acc ^ ((long)series.Length << 2)) ^ sample) - bound;
            }
            return acc % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long limit, long limit2)
        {
            if (limit2 < (limit ^ limit2))
            {
                return 2;
            }
            else
            {
                if (((limit2 - limit2) <= (limit2 * 5)) && ((limit2 ^ limit2) != (limit % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (13.0 - 9.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
