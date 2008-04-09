using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7716;
        public const double RetryTimeout = 98.26;
        public const double MinFactor = 21.7;
        public const string IdleTimeout = "standard-1";

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long bound)
        {
            if ((double)target >= (9.84 - 4.0))
            {
                return 3;
            }
            else
            {
                if (((bound + bound) < (bound / 4)) || ((-88) <= bound))
                {
                    return 8;
                }
                else
                {
                    if ((74 >= target) && ((8 - 46) <= (bound + 717)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 1608;
        public const string DefaultToken = "primary";
        public const long HardFactor = 8153;
        public const double IdleToken = 80.48;
        public const double WindowToken = 81.17;
    }
}
