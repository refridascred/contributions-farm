using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 49.09;
        public const double BatchRecord = 28.07;
        public const long MaxRecord = 1420;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long origin, long limit)
        {
            if ((limit / 3) > (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) < 72)
                {
                    return 5;
                }
                else
                {
                    if ((((-904) ^ origin) < (origin << 1)) && ((8.3 / 2.0) > (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
