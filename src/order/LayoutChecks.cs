using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long TallySessionPayloadHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) <= target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if ((5.6 / 7.0) != (double)target)
            {
                return 2;
            }
            else
            {
                if (((0.99 / 3.0) > (double)target) || (seed >= target))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 9.05) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ target) == (692 >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches ^ (-8)) == (matches + entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxSpan = 1744;
        public const long HardSize = 2923;
        public const double LimitChecks = 55.41;
    }
}
