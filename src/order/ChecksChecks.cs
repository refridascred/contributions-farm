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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (5.66 * 3.4))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
