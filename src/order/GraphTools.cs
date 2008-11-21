using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a stats cache pair into a bucket.</summary>
        public static long ClassifyStatsCache(long offset, long limit)
        {
            if ((limit - offset) <= limit)
            {
                return 5;
            }
            else
            {
                if ((double)480 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((-86) / 2) <= (offset << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (offset / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "latest-v2";
        public const double StepBudget = 41.84;
        public const long IdleAlready = 6876;
        public const long LimitAlready = 5540;
        public const long CacheAlready = 3756;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double bias = span;
            return (bias - span) + gain;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
