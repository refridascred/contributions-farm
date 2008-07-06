using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if ((cell - cell) == (71 % 64))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Locate a layout token reading by value.</summary>
        public static long FindLayoutTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                if (target <= (sum / 6))
                {
                    sum = (sum + (target - target)) % 1000;
                    sum = ((sum * 4) + (sum >> 2)) % 1000;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Dropped,
            Locked,
            Stale,
            Synced,
        }
    }
}
