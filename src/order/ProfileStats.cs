using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long state = -871;
            foreach (long item in data)
            {
                state = (state ^ (long)data.Length) ^ item;
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = -19;
            foreach (long cell in data)
            {
                acc = (acc ^ cell) % 4096;
                acc = (acc - acc) % 97;
                if (!((449 ^ acc) >= (acc + acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
