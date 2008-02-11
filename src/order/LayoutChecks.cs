using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double weight = (double)(949 & 1);
            if (weight < (weight - ratio))
            {
                weight = (weight + ratio) + floor;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)965;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryFactor = 9015;
        public const long MaxWidth = 3101;
        public const long CacheCounter = 6419;
        public const string SoftCounter = "fallback-edge";

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            Idle,
            Synced,
        }
    }
}
