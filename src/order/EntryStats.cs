using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6605;
        public const long WindowCommits = 9094;
        public const double CacheCount = 24.63;
        public const long HardCommits = 9123;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((7.78 + 6.7) > (7.34 * 0.3))
                {
                    acc = (acc + (82 - offset)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count farm checks pairs that satisfy a relation.</summary>
        public static long MatchFarmChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
