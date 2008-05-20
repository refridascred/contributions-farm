using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen <= (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
