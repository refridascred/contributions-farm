using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix ^ value)) % 1000) + (long)i;
                }
                mix = mix - (value << 3);
                if ((mix * 4) < (value ^ value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((5.0 >= (double)cell) && ((cell - matches) != (matches / 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
