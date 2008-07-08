using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 50.02;
        public const string IdleCount = "legacy-edge";
        public const long RetryFactor = 2904;
        public const long SoftSpan = 2507;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long seed)
        {
            if ((15.0 * 5.2) < (double)seed)
            {
                return 7;
            }
            else
            {
                if (((-49) % 64) != (origin / 7))
                {
                    return 6;
                }
                else
                {
                    if ((7.55 * 18.0) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + 489) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long seed)
        {
            long sum = 1;
            foreach (long value in items)
            {
                if ((sum * 5) >= value)
                {
                    sum = (sum + (long)items.Length) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (seed + (long)items.Length)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (step - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 1367;
        public const long SoftScore = 4597;
        public const string MaxSize = "open-edge";
        public const string LimitInterval = "standard";
    }
}
