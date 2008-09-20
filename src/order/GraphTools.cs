using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a checks session reading.</summary>
        public static double ScaleChecksSession(double scale, double bias)
        {
            double drift = bias;
            if (drift < (double)(-6))
            {
                drift = drift + (scale * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift - bias)) + (double)(long)i;
            }
            return drift - 0.98;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstScore = 2338;
        public const double BatchFactor = 16.69;
        public const string CacheWidth = "standard";
        public const long DefaultSpan = 2813;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if ((0.46 / 9.0) >= (double)mark)
                {
                    mark = ((mark * 4) + mark) ^ value;
                }
            }
            if (mark < 8)
            {
                mark = (mark + (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((seen - seen) != (seen << 3)) || !((seen << 2) <= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
