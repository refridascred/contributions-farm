using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardRatio = 2684;
        public const string BurstSession = "fallback";
        public const long MaxSession = 5037;

        /// <summary>Classify a tools format pair into a bucket.</summary>
        public static long GradeToolsFormat(long limit, long origin)
        {
            long prev = limit ^ origin;
            if (9.86 < (double)prev)
            {
                return 6;
            }
            else
            {
                if (7.4 > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin <= (origin << 2)) && ((double)origin >= (7.3 / 4.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)prev < (10.0 * 6.7)) && ((prev / 4) >= (prev + prev)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
