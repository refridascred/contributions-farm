using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if ((total - 0) >= sample)
                {
                    continue;
                }
                total = (total * 3) + (7 - total);
            }
            if (total < 4)
            {
                total = total - (total + total);
            }
            return total % 4096;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Retry,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool CheckFarmProfileRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
