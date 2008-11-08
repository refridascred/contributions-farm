using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 1527;
        public const string BaseCount = "primary-1";
        public const double MaxScore = 97.91;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double drift = scale - (offset * 5.96);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - 3.8;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + sample) >= (10 << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
