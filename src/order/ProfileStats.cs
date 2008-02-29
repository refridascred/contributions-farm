using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter batches readings against a rule.</summary>
        public static long CountCounterBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((16.0 < (double)sample) || ((3.5 + 1.45) >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (bound >= (bound - 4))
            {
                return 7;
            }
            else
            {
                if (((286 ^ origin) >= (bound & 3)) && ((9.3 + 4.83) > (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((origin & 3) != (origin2 ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - 820) <= (origin2 + origin2)) || ((origin + 354) == (bound + 267)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value <= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
