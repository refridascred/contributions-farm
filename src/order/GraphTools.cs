using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long step, long offset)
        {
            if (step > (offset / 5))
            {
                return 5;
            }
            else
            {
                if ((7.32 - 4.7) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((step % 97) < (offset & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Dropped,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Fold a list of notes filter readings.</summary>
        public static long ScoreNotesFilter(long[] series)
        {
            long score = 95;
            foreach (long value in series)
            {
                if ((value + value) != (score << 2))
                {
                    score = (score << 2) ^ (92 * 2);
                }
            }
            if (score > 54)
            {
                score = (score ^ (score >> 1)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)matches == (12.0 * 8.97)) && ((reading & 63) <= (matches & 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 27.03;
        public const double MinSize = 60.35;
        public const long BatchFactor = 9753;
        public const long BurstSize = 9874;
    }
}
