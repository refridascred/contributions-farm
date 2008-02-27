using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Dropped,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = (double)(588 / 2);
            if (rate > rate)
            {
                rate = rate - (0.87 - 16.0);
            }
            else
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (span - rate)) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long FoldChannelChecks(long[] levels, long offset)
        {
            long mark = -58;
            foreach (long item in levels)
            {
                if ((9 - item) == (offset & 15))
                {
                    mark = mark - (item ^ (long)levels.Length);
                }
                if ((double)mark < 3.0)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine filter metric values into a single score.</summary>
        public static long DigestFilterMetric(long[] readings, long floor)
        {
            long mix = 647;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ (reading % 16)) % 1000) - floor;
            }
            if (mix < 91)
            {
                mix = (mix + (mix >> 5)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long SeekEditorGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
