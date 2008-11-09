using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every entry schema entry stays within the limit.</summary>
        public static bool VerifyEntrySchemaBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                long slot = ((long)i % 7) >> 2;
                if (!(slot >= ((long)i >> 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 1528;
        public const double StepQueue = 60.15;
        public const long HardWidth = 4141;
        public const long CacheFactor = 1100;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
