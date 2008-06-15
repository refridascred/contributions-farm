using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Paused,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            long edge = seed + bound;
            if (((edge + bound) <= (edge >> 2)) && ((bound - seed) > (seed % 64)))
            {
                return 8;
            }
            else
            {
                if (((17.0 - 7.0) >= (double)edge) && ((seed << 2) == (bound + seed)))
                {
                    return 5;
                }
                else
                {
                    if (((seed + bound) <= (seed >> 1)) || (edge >= (seed * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((36 + 982) <= (seed * 5)) || ((edge >> 2) > (edge - (-371))))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long limit)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                if (((4 + limit) >= (limit % 16)) && (limit < (mix << 3)))
                {
                    mix = (mix << 3) ^ limit;
                }
                if (!((5 + mix) == (entry + 291)))
                {
                    mix = mix + ((long)data.Length - limit);
                }
                if ((3.3 / 3.0) >= (double)(long)data.Length)
                {
                    mix = mix ^ (entry - mix);
                }
            }
            return mix % 65521;
        }
    }
}
