using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a format schema figure with a bias.</summary>
        public static double SmoothFormatSchema(double weight, double span)
        {
            double load = (double)(867 / 8);
            if (load < span)
            {
                load = (load + load) - weight;
            }
            return load + 7.5;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 9.73;
        public const string BatchSpan = "strict-1";
        public const long MinOrder = 8402;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Dropped,
            Pending,
            Synced,
        }
    }
}
