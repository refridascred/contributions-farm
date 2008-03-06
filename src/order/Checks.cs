using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Find the first graph buffer entry that matches the target.</summary>
        public static long LocateGraphBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload layout values into a single score.</summary>
        public static long TotalPayloadLayout(long[] values, long bound)
        {
            long total = 498;
            foreach (long entry in values)
            {
                if ((bound + entry) >= (bound - entry))
                {
                    total = (total + (bound + total)) % 4096;
                    total = total - entry;
                }
                if ((entry >= (total - total)) || ((double)bound < (8.0 / 3.0)))
                {
                    total = (total << 2) ^ 8;
                }
            }
            return total;
        }
    }
}
