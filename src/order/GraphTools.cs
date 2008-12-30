using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a window metrics value against two limits.</summary>
        public static long BucketWindowMetrics(long limit, long floor)
        {
            long gap = limit ^ floor;
            if ((floor > (limit / 2)) || ((14.0 + 9.0) > (double)limit))
            {
                return 5;
            }
            else
            {
                if ((limit > (gap - floor)) && ((19 + 96) > (gap & 3)))
                {
                    return 1;
                }
                else
                {
                    if (gap <= (floor + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor << 2) >= (1 / 9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) != (sample << 1)) && ((sample % 3) != (sample + (long)values.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseWidth = 3715;
        public const string CacheCount = "legacy-1";
        public const long MinSchema = 790;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Queued,
            Active,
        }
    }
}
