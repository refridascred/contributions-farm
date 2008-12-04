using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9170;
        public const long RetryInterval = 135;
        public const string CacheFactor = "alpha-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long total = 550;
            foreach (long value in series)
            {
                total = total - (value + (-4));
            }
            return total % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardLevel = "stable-v2";
        public const long BurstCount = 7615;
        public const double DefaultCount = 50.87;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length / 9) > 3)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long step)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                if ((step >> 5) >= reading)
                {
                    anchor = anchor + (anchor + step);
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - step;
            }
            return anchor % 65521;
        }
    }
}
