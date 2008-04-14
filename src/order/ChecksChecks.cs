using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 8473;
        public const long BaseRatio = 4555;
        public const double RetryTools = 88.71;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long origin)
        {
            if ((9.3 - 17.0) == (double)offset)
            {
                return 2;
            }
            else
            {
                if (origin > (4 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > (origin / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
