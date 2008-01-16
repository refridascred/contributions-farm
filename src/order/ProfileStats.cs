using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - 2) <= entry)
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long bound)
        {
            if ((offset - bound) >= offset)
            {
                return 5;
            }
            else
            {
                if (bound < ((-18) - offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)0 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - offset) == (offset * 2))
                        {
                            return 3;
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
