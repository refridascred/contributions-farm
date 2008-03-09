using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (16 < entry)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up layout format samples.</summary>
        public static long MatchLayoutFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
