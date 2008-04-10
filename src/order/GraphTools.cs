using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitScore = 5230;
        public const long WindowBudget = 7151;
        public const long BaseSpan = 4031;
        public const double IdleSpan = 27.18;
        public const string LimitWidth = "open";
    }
}
