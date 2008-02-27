using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                if ((double)value >= 13.0)
                {
                    anchor = anchor - value;
                }
                if ((value & 31) != (anchor + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data)
        {
            long acc = 202;
            foreach (long entry in data)
            {
                if ((5.0 / 7.0) > (double)acc)
                {
                    acc = (acc - (236 >> 3)) + entry;
                }
                else
                {
                    acc = (acc + acc) % 97;
                }
            }
            if (acc < 7)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long floor)
        {
            long total = 8;
            foreach (long entry in items)
            {
                total = (total + (entry + total)) % 65521;
            }
            if (total < 0)
            {
                total = (total * 2) + floor;
            }
            return total;
        }
    }
}
