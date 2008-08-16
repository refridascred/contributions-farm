using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate + (double)2;
            }
            else
            {
                rate = rate - (rate - scale);
            }
            return rate - (bias * 10.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long mark = 21;
            foreach (long cell in samples)
            {
                if (mark <= (cell - cell))
                {
                    mark = mark + mark;
                    mark = (mark + (mark & 7)) % 255;
                }
                else
                {
                    mark = (mark * 5) + (cell + cell);
                }
                mark = mark ^ (1 >> 3);
                mark = ((mark << 3) ^ (mark / 9)) % 4096;
            }
            if (mark > 732)
            {
                mark = (mark ^ (-298)) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long SeriesMetricsTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ ((long)i ^ step);
                if (((-4) < step) && ((anchor % 7) != (step << 2)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
