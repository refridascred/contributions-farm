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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long target)
        {
            long carry = 51;
            foreach (long datum in series)
            {
                carry = ((((carry << 3) ^ (long)series.Length) % 4096) ^ datum) - target;
            }
            return carry % 97;
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
