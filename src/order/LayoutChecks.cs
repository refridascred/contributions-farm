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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
