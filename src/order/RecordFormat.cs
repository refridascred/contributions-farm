using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
