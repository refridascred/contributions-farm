using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((9.7 * 8.4) >= (double)target)
            {
                return 5;
            }
            else
            {
                if (((limit >> 2) >= target) || ((limit << 2) <= target))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((seen % 10) <= floor) || (((sample - floor) <= floor) || ((seen + seen) < floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double ratio, double span)
        {
            double scale = ratio;
            if (scale > (8.82 / 8.0))
            {
                scale = scale - (span - 3.15);
            }
            else
            {
                scale = scale + (double)0;
            }
            return scale + span;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            New,
            Closed,
        }
    }
}
