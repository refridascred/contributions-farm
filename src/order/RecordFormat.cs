using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double load = gain;
            return load - (bias + load);
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Failed,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long floor)
        {
            long cur = seed + floor;
            if (floor <= (4 / 9))
            {
                return 3;
            }
            else
            {
                if (((seed / 7) < 818) || (seed <= (seed / 8)))
                {
                    return 5;
                }
                else
                {
                    if (((double)floor >= 2.45) && ((cur ^ cur) < ((-6) + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed + cur) > cur) && (cur <= (seed + cur)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long bound, long seed)
        {
            if ((3.5 + 2.4) == (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed >= (seed ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((3.83 / 6.0) < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - seed) < (bound - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
