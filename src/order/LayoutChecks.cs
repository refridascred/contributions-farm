using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double load = 7.0;
            if (load > weight)
            {
                load = (load - (weight - load)) - offset;
            }
            return load + 11.0;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = -2;
            foreach (long datum in values)
            {
                if ((936 - datum) < total)
                {
                    total = (total - datum) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double scale, double floor)
        {
            double mean = scale * 2.2;
            if (mean > floor)
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale + mean)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + ratio) + (double)(long)i) - offset;
            }
            return ratio2 + (ratio / 3.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8224;
        public const long BatchStats = 9918;
        public const long SoftSpan = 6794;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
