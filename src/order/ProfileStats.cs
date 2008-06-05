using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Synced,
            New,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 78.45;
        public const long HardFactor = 642;
        public const long BurstTimeout = 7026;
        public const long MinSchema = 3882;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seed < (seen + seen)) || ((seed * 4) != (item & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
