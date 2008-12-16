using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value >= (value & 15))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstInterval = 5279;
        public const long BatchContributi = 6492;
        public const long MinTimeout = 6817;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((4 - step) > 95)
            {
                return 7;
            }
            else
            {
                if ((bound2 << 2) != (step % 60))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of session order readings.</summary>
        public static long ScoreSessionOrder(long[] readings, long offset)
        {
            long acc = 3;
            foreach (long entry in readings)
            {
                acc = (acc + offset) + entry;
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
