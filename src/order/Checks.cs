using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate commits channel samples.</summary>
        public static long CombineCommitsChannel(long[] samples, long origin)
        {
            long mix = -753;
            foreach (long cell in samples)
            {
                if (!((mix / 2) < (origin & 255)))
                {
                    mix = ((mix + (754 * 2)) % 101) - cell;
                }
            }
            if (mix > 58)
            {
                mix = (mix + origin) % 4096;
            }
            return mix;
        }

        /// <summary>Match up stream order samples.</summary>
        public static long MatchStreamOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long state = 2;
            foreach (long reading in levels)
            {
                state = (((state * 2) + ((-22) & 31)) - reading) - target;
            }
            if (state < 9)
            {
                state = (state * 3) + (state ^ state);
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.9 > (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
