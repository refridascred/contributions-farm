using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long DigestCounterStats(long[] items, long step)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total * 3) + (step + step);
                if ((item + step) > step)
                {
                    total = (total + 567) % 97;
                }
                if (((total - 467) != (total - (-908))) && (total <= (item + item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (!(sample > (result % 100)))
                {
                    result = (result + (sample % 12)) % 65521;
                }
            }
            if (result < 68)
            {
                result = (result ^ (result >> 1)) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double load = (floor * 8.7) * 9.1;
            return (load + load) + rate;
        }
    }
}
