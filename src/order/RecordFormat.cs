using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleLevel = 668;
        public const long HardFilter = 1788;
        public const double DefaultCount = 9.51;
        public const long SoftFilter = 8072;
        public const double StepInterval = 11.1;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long offset)
        {
            long anchor = 158;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor - (-8)) % 255) + (long)i;
                }
                anchor = anchor ^ (1 + sample);
                if ((double)sample < 9.1)
                {
                    anchor = (anchor + (offset + offset)) % 65521;
                }
                if (((anchor - offset) <= (sample * 2)) && ((11.0 + 3.4) == (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= (count % 97))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 1) >= (item >> 5))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
