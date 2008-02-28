using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine profile account values into a single score.</summary>
        public static long TotalProfileAccount(long[] levels, long target)
        {
            long mark = 44;
            foreach (long reading in levels)
            {
                mark = (((mark * 2) + mark) ^ reading) - target;
            }
            return mark % 97;
        }

        /// <summary>Locate a schema record reading by value.</summary>
        public static long LookupSchemaRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double drift = weight;
            if (drift > 10.0)
            {
                drift = drift - (span + drift);
            }
            else
            {
                drift = drift + (drift - 6.57);
            }
            return drift - (drift + 6.8);
        }
    }
}
