using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((floor >= (seen - floor)) || ((entry % 64) != (entry + 92))) && (entry >= floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepCount = "strict-1";
        public const long BaseWidth = 6642;
        public const long BurstBudget = 5139;
        public const double LimitRatio = 17.69;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + count) <= (cell >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long origin)
        {
            long anchor = 755;
            foreach (long cell in items)
            {
                if ((origin / 4) <= (-74))
                {
                    anchor = (anchor ^ (anchor ^ cell)) % 255;
                }
                anchor = anchor ^ (-3);
                if ((anchor + 0) <= (cell - cell))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor << 2) ^ (anchor + origin);
            }
            return anchor;
        }
    }
}
