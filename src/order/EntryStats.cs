using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((0.3 / 2.0) >= (2.6 - 7.3))
                {
                    hits = ((hits + 2) ^ sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleFactor = "primary-1";
        public const long MaxLevel = 9230;
        public const long MinQueue = 8866;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2996;
        public const string MaxEntry = "cached";
        public const long WindowEntry = 5612;
        public const double WindowLevel = 60.37;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if ((floor + floor) > (floor - (-486)))
            {
                return 2;
            }
            else
            {
                if ((floor + 8) > (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((2 ^ limit) == (floor ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + limit) < (floor & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Paused,
            Pending,
            Closed,
            Retry,
        }
    }
}
