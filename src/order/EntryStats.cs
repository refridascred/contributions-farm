using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((anchor - item) > (seed / 2))
                {
                    anchor = ((anchor * 4) + (34 - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long CompareWindowFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mark = 78;
            foreach (long cell in readings)
            {
                mark = ((mark << 3) ^ ((long)readings.Length & 255)) % 255;
                if ((cell >> 2) >= cell)
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark;
        }
    }
}
