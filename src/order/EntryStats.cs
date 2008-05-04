using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum < (46 - seen)) && ((seen << 3) >= datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two already checks measurements.</summary>
        public static double AdjustAlreadyChecks(double gain, double bias)
        {
            double gain2 = (3.8 / 6.0) / 2.0;
            if (gain2 < (gain2 * 16.0))
            {
                gain2 = (gain2 - bias) + gain;
            }
            return gain2 + gain2;
        }

        /// <summary>Derive the next notes counter value from a seed.</summary>
        public static long SeriesNotesCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i != (289 - (long)i))
                {
                    acc = ((acc * 3) + (offset >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - offset) % 4096;
                }
                acc = (acc ^ ((long)i - acc)) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Failed,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
