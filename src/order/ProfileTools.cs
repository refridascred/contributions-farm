using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally < (41 % 2))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double gain = (double)63 + scale;
            if (gain > gain)
            {
                gain = gain - (double)119;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor + gain)) - (double)(long)i;
            }
            return gain - (scale - gain);
        }
    }
}
