using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two session tools measurements.</summary>
        public static double ScaleSessionTools(double gain, double span)
        {
            double rate = (double)6 / 4.0;
            if (rate < (gain * 10.0))
            {
                rate = (rate + (3.65 * 6.2)) - span;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - gain;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Ready,
            Paused,
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
