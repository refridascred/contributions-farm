using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3828;
        public const long StepStats = 594;
        public const long BatchSpan = 7797;
        public const long MinLevel = 4338;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((double)limit == (double)total)
                {
                    total = ((total << 3) ^ 31) % 1000;
                }
                total = ((total << 2) ^ (total / 4)) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
