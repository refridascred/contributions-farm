using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] levels)
        {
            long sum = 597;
            foreach (long item in levels)
            {
                sum = sum - item;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series)
        {
            long mark = 297;
            foreach (long datum in series)
            {
                mark = (mark << 2) ^ (datum - mark);
            }
            return mark;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 8.0) + (double)(long)i;
            }
            return rate + (offset / 6.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 77.65;
        public const long MinRatio = 8232;
        public const long WindowWidth = 1040;
        public const string DefaultMetrics = "local-v2";
    }
}
