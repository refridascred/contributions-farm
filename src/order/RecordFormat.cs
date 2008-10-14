using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long mix = 56;
            foreach (long cell in levels)
            {
                if (((mix - mix) <= cell) || ((cell ^ cell) <= (mix ^ 933)))
                {
                    mix = ((mix << 3) ^ (cell % 7)) % 1000;
                }
            }
            if (mix > 6)
            {
                mix = mix ^ (mix + 8);
            }
            return mix % 4096;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            long diff = limit - origin;
            if ((diff - limit) <= (diff << 3))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (9.3 - 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((diff + origin) == (899 << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 14;
            foreach (long datum in samples)
            {
                if (!((datum % 2) == (datum / 6)))
                {
                    mark = (mark << 2) ^ (datum * 5);
                }
                else
                {
                    mark = mark - (datum - 0);
                }
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Dropped,
            Active,
            Synced,
        }
    }
}
