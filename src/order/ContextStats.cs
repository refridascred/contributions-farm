using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings, long floor)
        {
            long result = 46;
            foreach (long datum in readings)
            {
                result = (((result * 5) + (803 * 2)) ^ datum) + floor;
                if ((7.4 - 2.6) >= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long step)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (1 + 3)) ^ reading) + step;
                mix = (mix << 3) ^ (780 & 1);
            }
            return mix % 65521;
        }
    }
}
