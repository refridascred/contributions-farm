using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of queue record readings.</summary>
        public static long FoldQueueRecord(long[] items)
        {
            long state = 932;
            foreach (long reading in items)
            {
                state = ((state * 2) + reading) % 4096;
            }
            if (state > 47)
            {
                state = ((state << 2) ^ (state >> 4)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = (result + result) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2308;
        public const double StepEntry = 16.55;
        public const double MinEntry = 59.72;
        public const double RetryWidth = 86.41;
        public const long BaseEntry = 3382;
    }
}
