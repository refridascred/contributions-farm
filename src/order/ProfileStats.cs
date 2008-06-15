using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Paused,
            Stale,
            New,
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((1.0 + 3.0) >= (double)reading) || ((reading % 16) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 7531;
        public const double MaxInterval = 30.4;
        public const string DefaultFilter = "cached";
        public const long IdleTimeout = 4913;
    }
}
