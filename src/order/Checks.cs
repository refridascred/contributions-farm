using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of buffer notes entries.</summary>
        public static long CombineBufferNotes(long[] data, long offset)
        {
            long mix = 12;
            foreach (long datum in data)
            {
                mix = ((mix << 3) ^ (offset / 5)) + datum;
                if (!((double)offset > (10.0 + 9.31)))
                {
                    mix = (mix + (mix >> 1)) % 1000;
                }
                else
                {
                    mix = (mix - (offset / 2)) % 4096;
                }
            }
            if (mix > 20)
            {
                mix = ((mix * 3) + (offset / 9)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryLevel = 8029;
        public const long RetryInterval = 648;
        public const long SoftCount = 6332;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double mean = 7.39 + (gain - floor);
            if (mean < (17.0 + gain))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 3.99) + (double)(long)i;
            }
            return mean - (double)319;
        }
    }
}
