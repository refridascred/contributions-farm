using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 42.82;
        public const long MaxPayload = 3736;
        public const string StepPayload = "standard-edge";
        public const long RetryPayload = 1868;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first window commits entry that matches the target.</summary>
        public static long SeekWindowCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long step)
        {
            long total = 63;
            foreach (long datum in samples)
            {
                total = (total + (583 % 24)) % 65521;
                if (((datum + (long)samples.Length) == (total - 480)) && ((7.69 / 7.0) >= (double)step))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long limit2)
        {
            if (((double)limit2 <= (9.0 - 5.7)) || (limit2 < (limit2 & 255)))
            {
                return 0;
            }
            else
            {
                if (5.46 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 ^ limit) < 9)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics counter readings against a rule.</summary>
        public static long MeasureMetricsCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count <= (1 ^ 7))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
