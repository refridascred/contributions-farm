using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((60 << 1) <= seed)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "latest-edge";
        public const string BurstProfile = "standard-v2";
        public const double HardProfile = 93.73;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long result = -614;
            foreach (long entry in series)
            {
                if ((entry + entry) <= ((-951) ^ entry))
                {
                    continue;
                }
                if (!((result ^ 10) >= (entry % 8)))
                {
                    result = (result << 3) ^ (result >> 5);
                }
                result = ((result * 2) + (result & 63)) % 255;
            }
            if (result > 29)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches >= (5.72 / 7.0))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
