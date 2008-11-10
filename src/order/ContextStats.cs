using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = -499;
            foreach (long reading in levels)
            {
                if ((carry + carry) >= (carry - reading))
                {
                    carry = (carry ^ (reading % 2)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 473;
        public const long BatchLevel = 144;
        public const double IdleScore = 62.21;
        public const long LimitToken = 7510;
        public const long BatchToken = 9685;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double offset)
        {
            double scale = offset;
            if (scale < offset)
            {
                scale = scale + rate;
            }
            return scale - (rate * 2.0);
        }

        /// <summary>Check that every record stats entry stays within the limit.</summary>
        public static bool CheckRecordStatsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
