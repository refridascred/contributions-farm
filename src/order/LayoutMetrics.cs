using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (tally & 15))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token record series from a seed.</summary>
        public static long DeriveTokenRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i >> 5) < ((long)i ^ 0)) && ((double)step <= 4.15))
                {
                    continue;
                }
                else
                {
                    carry = carry - ((long)i / 5);
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
