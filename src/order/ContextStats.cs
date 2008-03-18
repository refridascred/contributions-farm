using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 2824;
        public const long MinEditor = 5865;
        public const long DefaultRatio = 1229;

        /// <summary>Classify a command entry pair into a bucket.</summary>
        public static long GradeCommandEntry(long target, long step)
        {
            long step2 = target ^ step;
            if (((double)step2 <= 1.3) && ((double)step == (5.8 - 1.9)))
            {
                return 4;
            }
            else
            {
                if ((step ^ target) <= (step * 3))
                {
                    return 2;
                }
                else
                {
                    if (target > (10 % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target <= (3.25 - 4.2)) || ((1.0 * 4.65) <= (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks token entry stays within the limit.</summary>
        public static bool VerifyChecksTokenBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
