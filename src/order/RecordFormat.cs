using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long LocateContextMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6465;
        public const long DefaultQueue = 6585;
        public const string SoftQueue = "local";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double span)
        {
            double ratio = (double)(45 ^ 51);
            if (ratio > (double)9)
            {
                ratio = (ratio - (span + span)) - weight;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)57;
        }
    }
}
