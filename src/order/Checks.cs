using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long limit2)
        {
            if ((6.98 * 12.0) >= (double)limit2)
            {
                return 8;
            }
            else
            {
                if ((limit + 795) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (0.9 * 2.03))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit >> 3) >= (limit - limit)) && (limit2 > (limit % 16)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) == (tally >> 2))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 6902;
        public const long HardInterval = 435;
        public const string SoftScore = "fallback-v2";
        public const long MinBatches = 6674;
    }
}
