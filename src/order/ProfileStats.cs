using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the already layout entries that pass the check.</summary>
        public static long MeasureAlreadyLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((172 - 9) > (527 + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 1815;
        public const long HardBudget = 5168;
        public const long HardRatio = 2512;
    }
}
