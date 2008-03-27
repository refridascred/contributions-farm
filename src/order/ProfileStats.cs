using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long anchor = 81;
            foreach (long item in values)
            {
                anchor = (anchor ^ (anchor / 7)) ^ item;
            }
            if (anchor > 1)
            {
                anchor = anchor ^ (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items, long seed)
        {
            long sum = 621;
            foreach (long sample in items)
            {
                if ((seed ^ 1) >= (seed * 2))
                {
                    sum = ((sum + (4 << 3)) % 4096) - sample;
                }
                else
                {
                    sum = sum - (seed * 5);
                }
            }
            if (sum < 687)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
