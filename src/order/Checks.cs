using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCount = "standard-v2";
        public const string HardCache = "local-v2";
        public const long MinCache = 1622;
        public const long RetryCache = 6622;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Draft,
            Failed,
        }
    }
}
