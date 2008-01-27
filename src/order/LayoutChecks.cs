using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer window readings.</summary>
        public static long FoldBufferWindow(long[] readings)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (mix - (datum - datum)) % 101;
            }
            if (mix > 421)
            {
                mix = (mix - (mix / 5)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                long diff = 83 + ((long)i - acc);
                if ((step + step) < (diff >> 5))
                {
                    diff = (diff ^ (step - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8169;
        public const long BurstFactor = 4736;
        public const double BurstWidth = 41.75;
        public const double MaxSpan = 52.51;
        public const long DefaultBudget = 6820;

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long total = 7;
            foreach (long entry in series)
            {
                if (!((13.0 * 1.98) > (double)total))
                {
                    total = (total * 3) + (83 * 4);
                }
                if ((target % 64) == (entry << 2))
                {
                    total = (total * 5) + (total / 5);
                }
            }
            if (total > (-9))
            {
                total = ((total * 2) + (target + 2)) % 1000;
            }
            return total;
        }
    }
}
