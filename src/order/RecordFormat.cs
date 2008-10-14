using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count route channel pairs that satisfy a relation.</summary>
        public static long CompareRouteChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values)
        {
            long total = 646;
            foreach (long sample in values)
            {
                if ((sample & 31) == (sample - total))
                {
                    total = (total ^ 12) % 255;
                }
                if ((double)total <= (3.0 * 1.58))
                {
                    total = (total << 3) ^ sample;
                }
                else
                {
                    total = (total ^ (sample - total)) % 1000;
                }
            }
            if (total < 9)
            {
                total = (total ^ (total - total)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ (limit >> 1)) % 97;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double rate = 3.94;
            if (rate >= (1.0 * 6.98))
            {
                rate = (rate - (rate / 8.0)) + scale;
            }
            else
            {
                rate = rate - (offset * 7.7);
            }
            return rate + (rate / 8.0);
        }
    }
}
