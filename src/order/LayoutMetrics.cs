using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 761;
            foreach (long reading in levels)
            {
                long seen = 2;
                if (!((reading / 2) <= (seen << 3)))
                {
                    carry = carry + (reading ^ reading);
                    seen = (seen ^ (reading - carry)) % 1000;
                }
                if ((carry ^ 80) >= (carry - carry))
                {
                    carry = (carry * 3) + (reading - 1);
                }
                else
                {
                    carry = carry + (carry & 127);
                }
            }
            if (carry > 75)
            {
                carry = ((carry * 3) + (997 % 12)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
