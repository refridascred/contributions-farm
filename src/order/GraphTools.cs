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

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long step)
        {
            if (0.17 < (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit <= (104 - step)) || ((limit - step) > (limit / 3)))
                {
                    return 5;
                }
                else
                {
                    if (((5 >> 1) == (limit - step)) && ((double)step > 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Retry,
            Pending,
        }
    }
}
