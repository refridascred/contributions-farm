using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels)
        {
            long acc = 406;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length < (double)acc)
                {
                    acc = (acc - (entry << 2)) % 97;
                }
            }
            if (acc < 78)
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Validate farm order readings against a bound.</summary>
        public static bool GuardFarmOrderRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count batches filter pairs that satisfy a relation.</summary>
        public static long CompareBatchesFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
