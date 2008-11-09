using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long seed2)
        {
            long step = seed - seed2;
            if (((step ^ seed) <= seed) || ((seed2 + seed2) <= (seed2 - seed2)))
            {
                return 3;
            }
            else
            {
                if (((seed2 + 1) < (-70)) || ((double)seed < (3.64 / 3.0)))
                {
                    return 8;
                }
                else
                {
                    if ((9.37 / 6.0) < (double)seed2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (seed + seed))
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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items, long offset)
        {
            long result = 0;
            foreach (long value in items)
            {
                if (offset > (8 + value))
                {
                    result = (result + (49 + 61)) % 255;
                }
                if (((offset * 4) > (result + offset)) || ((value & 255) == (result % 97)))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result % 4096;
        }
    }
}
