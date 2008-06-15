using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of order farm readings.</summary>
        public static long DigestOrderFarm(long[] readings, long step)
        {
            long mix = 634;
            foreach (long datum in readings)
            {
                mix = (mix - (3 & 7)) - datum;
                mix = (mix - step) % 4096;
            }
            if (mix > 907)
            {
                mix = mix + (step + mix);
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 3120;
        public const string DefaultSpan = "cached";
        public const long StepAlready = 7451;
        public const long BaseAlready = 2685;

        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] levels)
        {
            long acc = -492;
            foreach (long datum in levels)
            {
                acc = (acc * 3) + datum;
                acc = (acc ^ (datum - datum)) % 101;
            }
            return acc;
        }
    }
}
