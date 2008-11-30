using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double gain = weight;
            if (gain > 4.37)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 5.37) + (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2815;
        public const long MaxSession = 3604;
        public const long StepSession = 835;
        public const long SoftSession = 7000;
        public const string MinSize = "cached-v2";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long floor)
        {
            long carry = 642;
            foreach (long sample in series)
            {
                if ((double)floor >= (double)sample)
                {
                    carry = (carry << 2) ^ (carry + 4);
                }
                carry = (carry * 3) + (floor ^ carry);
                if ((carry <= (carry - carry)) && ((double)carry != (double)90))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
