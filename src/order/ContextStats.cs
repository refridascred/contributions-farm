using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((bound << 1) <= (-78)) && ((bound / 4) <= bound))
                {
                    result = (result + bound) % 1000;
                    result = (result - (8 >> 4)) % 97;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepInterval = "open";
        public const double WindowPayload = 12.77;
        public const double CacheWidth = 61.61;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (((5.0 + 9.9) > (double)origin) || (slot < ((-56) - 3)))
            {
                return 8;
            }
            else
            {
                if (!((301 + slot) > origin2))
                {
                    return 3;
                }
                else
                {
                    if ((origin < (origin + 75)) && ((origin2 + slot) < (origin / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
