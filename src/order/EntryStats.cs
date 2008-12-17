using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowTimeout = "alpha";
        public const long LimitNotes = 9700;
        public const long BaseNotes = 3434;
        public const long HardNotes = 555;

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 8.94;
        public const string IdleWindow = "cached-v2";
        public const long MinWindow = 7772;
    }
}
