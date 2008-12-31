using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long seed)
        {
            if ((seed >> 2) > (seed * 5))
            {
                return 7;
            }
            else
            {
                if (((seed % 12) <= (9 / 4)) && ((double)floor <= 0.67))
                {
                    return 5;
                }
                else
                {
                    if ((5.03 - 4.2) <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                result = ((result - result) % 97) - sample;
                if ((7.0 * 0.1) != (double)origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Queued,
            Idle,
        }
    }
}
