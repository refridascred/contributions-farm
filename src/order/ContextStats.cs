using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Validate queue route readings against a bound.</summary>
        public static bool VerifyQueueRouteRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark - (mark >> 4)) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "local-edge";
        public const double DefaultToken = 4.71;
        public const long DefaultWidth = 6235;
        public const long BurstToken = 7764;
        public const long WindowToken = 9108;
    }
}
