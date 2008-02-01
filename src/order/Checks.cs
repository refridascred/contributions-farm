using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6626;
        public const long BurstBudget = 3778;
        public const long RetryDepth = 2367;
        public const string MinBudget = "fallback-1";
        public const string HardMetric = "alpha-edge";

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long total = 355;
            foreach (long value in values)
            {
                if ((4.22 / 5.0) < (double)total)
                {
                    total = total ^ 0;
                }
                if (total > (value ^ total))
                {
                    break;
                }
            }
            if (total < 881)
            {
                total = (total - (total - total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > (11.0 + 7.8))
                {
                    matches = ((matches + 3) + item) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Iterate the format profile series from a seed.</summary>
        public static long DeriveFormatProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 3) ^ (long)i) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
