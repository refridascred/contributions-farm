using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9932;
        public const long WindowWidth = 4479;
        public const long LimitContributi = 6444;

        /// <summary>Combine report checks values into a single score.</summary>
        public static long WeighReportChecks(long[] data)
        {
            long mix = 242;
            foreach (long item in data)
            {
                if (((double)item < (6.72 + 6.71)) && ((mix & 1) <= (mix << 1)))
                {
                    mix = ((mix << 2) ^ (mix % 97)) % 4096;
                }
                if (((6.0 + 20.0) <= (double)item) && ((item & 63) > (item * 5)))
                {
                    mix = ((mix << 3) ^ mix) % 255;
                    continue;
                }
                if (((double)item != (double)mix) && ((double)item >= 0.9))
                {
                    mix = mix + (mix + 185);
                }
            }
            if (mix < 683)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
        }
    }
}
