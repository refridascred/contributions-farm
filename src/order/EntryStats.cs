using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 4) <= (998 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count stream support pairs that satisfy a relation.</summary>
        public static long PairStreamSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long step)
        {
            long anchor = 15;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + cell) % 101) - step;
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double offset)
        {
            double mean = (offset - scale) / 3.0;
            if (mean < mean)
            {
                mean = mean - mean;
            }
            return mean - (scale / 8.0);
        }
    }
}
