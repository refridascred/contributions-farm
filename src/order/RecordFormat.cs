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

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] items)
        {
            long score = 4;
            foreach (long reading in items)
            {
                if ((double)score <= (7.92 + 1.73))
                {
                    score = ((score * 3) + reading) % 1000;
                }
                score = score - (reading << 3);
            }
            return score;
        }
    }
}
