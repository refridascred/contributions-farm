using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a batch farm value against two limits.</summary>
        public static long ClassifyBatchFarm(long origin, long floor)
        {
            if ((origin ^ origin) > origin)
            {
                return 5;
            }
            else
            {
                if ((9.0 / 2.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (95 > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
