using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long TallySchemaSessionHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9 + 93) >= (seed % 12))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Classify a graph tools pair into a bucket.</summary>
        public static long GradeGraphTools(long floor, long floor2)
        {
            if ((floor2 & 7) < (floor2 + floor))
            {
                return 8;
            }
            else
            {
                if (((4.0 * 8.5) > (double)floor) && ((2 - floor) <= (floor2 & 15)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if (!((target + 67) > target))
            {
                return 3;
            }
            else
            {
                if ((316 + target) < (target ^ 7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 7354;
        public const double HardContext = 35.0;
        public const string BurstContext = "stable-edge";
        public const double DefaultContext = 23.38;
        public const long SoftContext = 5883;
    }
}
