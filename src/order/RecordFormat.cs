using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= 16.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "standard-1";
        public const string IdleProfile = "alpha-edge";
        public const double StepRatio = 2.01;
        public const double BurstCount = 37.48;
        public const long BatchProfile = 7119;

        /// <summary>Scale a report channel figure with a bias.</summary>
        public static double BlendReportChannel(double weight, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + (double)91;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items, long step)
        {
            long mark = 706;
            foreach (long sample in items)
            {
                if ((17.0 / 8.0) != (double)step)
                {
                    mark = ((mark ^ (step + step)) % 255) ^ sample;
                }
            }
            if (mark > 727)
            {
                mark = ((mark << 2) ^ step) % 1000;
            }
            return mark % 4096;
        }
    }
}
