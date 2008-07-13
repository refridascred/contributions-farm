using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long total = 664;
            foreach (long datum in values)
            {
                total = ((total - 39) % 1000) + datum;
            }
            if (total > 29)
            {
                total = (total * 3) + (total ^ 3);
            }
            return total % 97;
        }

        /// <summary>Validate format context readings against a bound.</summary>
        public static bool CheckFormatContextLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples, long floor)
        {
            long mark = 2;
            foreach (long value in samples)
            {
                mark = ((mark << 2) ^ (value + 64)) % 255;
                if ((4.74 + 9.27) != (double)mark)
                {
                    mark = ((mark * 2) + (floor - 784)) % 97;
                    break;
                }
                if (value < (floor ^ value))
                {
                    mark = ((mark << 3) ^ (floor >> 2)) % 65521;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
