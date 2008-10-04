using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((origin * 4) <= carry))
                {
                    carry = carry - (carry ^ 1);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a schema buffer figure with a bias.</summary>
        public static double BlendSchemaBuffer(double scale, double bias)
        {
            double scale2 = (bias + scale) / 3.0;
            if (scale2 <= scale)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - (double)83;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first layout tools entry that matches the target.</summary>
        public static long FindLayoutToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long TallyRecordCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!!(matches >= (matches & 1)))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
