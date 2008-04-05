using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the context githubfarm series from a seed.</summary>
        public static long DeriveContextGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((sum - sum) != (sum % 97))
                {
                    long lane = sum - ((long)i ^ limit);
                    sum = sum + (lane * 3);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long origin)
        {
            if (((origin & 255) > limit) || ((5 + origin) >= 363))
            {
                return 5;
            }
            else
            {
                if (6.0 <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate context channel readings against a bound.</summary>
        public static bool ValidateContextChannelBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 622;
        public const long BurstFormat = 6239;
        public const long MaxFormat = 7759;
    }
}
