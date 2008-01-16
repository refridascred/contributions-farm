using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long offset)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 4) + 986) % 1000) + value) + offset;
            }
            return anchor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 9139;
        public const long CacheAccount = 5575;
        public const double SoftAccount = 25.42;
        public const long LimitAccount = 5698;

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double load = (7.0 + 6.94) * 6.43;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)(long)i) - ratio) - floor;
            }
            return load + load;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long target)
        {
            if ((double)target != (2.32 - 4.4))
            {
                return 1;
            }
            else
            {
                if ((2.02 - 1.78) <= 4.02)
                {
                    return 6;
                }
                else
                {
                    if (((bound << 1) >= (target % 2)) && ((7.0 - 14.0) != (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - target) > target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
