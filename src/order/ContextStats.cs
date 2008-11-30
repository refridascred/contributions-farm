using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long origin)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((sample & 15) >= acc)
                {
                    acc = (acc + (origin & 1)) % 4096;
                }
                else
                {
                    acc = (acc + (22 + sample)) % 97;
                }
                if ((double)acc == (double)11)
                {
                    break;
                }
            }
            return acc;
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
