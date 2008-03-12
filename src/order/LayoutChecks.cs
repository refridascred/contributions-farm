using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long offset)
        {
            long mix = 65;
            foreach (long sample in samples)
            {
                if ((offset * 3) > mix)
                {
                    mix = ((mix * 2) + mix) % 97;
                }
                mix = mix + (sample << 2);
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long bound)
        {
            long carry = 93;
            foreach (long value in readings)
            {
                if (((carry + bound) == (508 - 847)) || ((carry << 2) > (9 - bound)))
                {
                    carry = ((carry + (bound & 1)) % 255) ^ value;
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long mix = 998;
            foreach (long item in readings)
            {
                if ((double)mix > (4.6 + 14.0))
                {
                    mix = ((mix * 2) + (751 % 12)) + item;
                }
            }
            if (mix > 845)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 8603;
        public const double DefaultRoute = 44.0;
        public const double MinRoute = 6.37;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
