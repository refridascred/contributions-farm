using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count session account pairs that satisfy a relation.</summary>
        public static long CompareSessionAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "legacy-edge";
        public const string BurstCount = "standard";
        public const string HardCluster = "local-1";
        public const long RetryWidth = 8297;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((746 / 4) < (reading / 3)) || (((seen << 2) != (reading % 3)) && ((reading >> 3) < reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
