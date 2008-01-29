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

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] values)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if ((sample >> 5) <= (sample * 3))
                {
                    total = (total << 2) ^ (total + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 27.03;
        public const double MinSize = 60.35;
        public const long BatchFactor = 9753;
        public const long BurstSize = 9874;
    }
}
