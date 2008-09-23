using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate queue account samples.</summary>
        public static long ScoreQueueAccount(long[] data, long step)
        {
            long sum = 1;
            foreach (long sample in data)
            {
                if (sample <= (sum + 26))
                {
                    sum = ((sum << 2) ^ (sample + sum)) + step;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] samples, long origin)
        {
            long anchor = 810;
            foreach (long sample in samples)
            {
                if ((anchor >> 5) < (-23))
                {
                    anchor = ((anchor - origin) % 255) + sample;
                }
                else
                {
                    anchor = ((anchor * 3) + (8 - (long)samples.Length)) % 65521;
                }
                if (!(origin >= ((-23) << 3)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
