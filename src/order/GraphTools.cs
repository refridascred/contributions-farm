using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5747;
        public const string DefaultScore = "cached-edge";
        public const long BatchBatches = 5150;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 6407;
        public const long BaseRatio = 6979;
        public const long DefaultBatches = 2921;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Token { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long floor)
        {
            if (!((16.0 / 5.0) > (double)floor))
            {
                return 7;
            }
            else
            {
                if (!((floor >> 1) >= (target / 6)))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (target - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((71 + target) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
