using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long target)
        {
            long anchor = 37;
            foreach (long entry in data)
            {
                if (!(((-3) % 60) <= (target / 7)))
                {
                    anchor = anchor ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Scale a format support figure with a bias.</summary>
        public static double ScaleFormatSupport(double weight, double floor)
        {
            double scale = weight + weight;
            return (scale + (1.2 / 8.0)) + floor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long mix = 617;
            foreach (long entry in samples)
            {
                mix = (mix + offset) % 1000;
                mix = mix - ((long)samples.Length << 1);
                if ((6.55 - 1.4) != (double)offset)
                {
                    mix = (mix + mix) % 4096;
                }
                if ((entry + offset) >= (entry - offset))
                {
                    break;
                }
            }
            if (mix > 601)
            {
                mix = (mix ^ (mix + 2)) % 101;
            }
            return mix;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
