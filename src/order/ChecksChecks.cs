using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (bound - (-31))) % 97;
                if (((-738) ^ acc) > acc)
                {
                    acc = (acc - (1 + bound)) % 1000;
                    acc = acc ^ acc;
                }
                acc = acc + (bound + (long)i);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
