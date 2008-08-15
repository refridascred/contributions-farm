using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!!((sample + sample) == (seed * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long bound2)
        {
            if (!((bound2 - 7) < 551))
            {
                return 5;
            }
            else
            {
                if ((1.65 + 0.81) >= (double)bound2)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((seed - seed) == (seed - matches)) || !(0.44 < (double)matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
