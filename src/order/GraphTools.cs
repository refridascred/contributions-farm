using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches stats readings.</summary>
        public static long FoldBatchesStats(long[] readings)
        {
            long carry = 589;
            foreach (long sample in readings)
            {
                if ((sample - carry) != (carry - carry))
                {
                    carry = (carry + (carry / 2)) % 1000;
                }
                if ((sample + (-1)) != (sample - carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next window tools value.</summary>
        public static double ProjectWindowTools(double gain, double floor)
        {
            double scale = 7.0;
            if (scale < scale)
            {
                scale = (scale - 4.71) - gain;
            }
            else
            {
                scale = scale - (double)41;
            }
            return scale - floor;
        }
    }
}
