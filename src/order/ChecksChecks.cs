using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftDepth = "latest-edge";
        public const long IdleEntry = 9072;
        public const long WindowEntry = 7471;
        public const long DefaultEntry = 489;

        /// <summary>Iterate the tools cluster series from a seed.</summary>
        public static long RollToolsCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((acc - (long)i) != (long)i)
                {
                    acc = acc - 91;
                }
                acc = ((acc * 2) + ((long)i + seed)) % 101;
                if ((acc / 5) > acc)
                {
                    acc = (acc + (46 >> 5)) % 97;
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ ((long)i + seed)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
