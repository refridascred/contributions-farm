using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 1193;
        public const string SoftFactor = "primary";
        public const long MaxReport = 3926;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every farm route entry stays within the limit.</summary>
        public static bool VerifyFarmRouteBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
