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

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double gain = 2.07;
            return (gain + bias) + weight;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Failed,
            Done,
            Ready,
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
