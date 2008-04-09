using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double rate = (double)(-24) / 9.0;
            return (rate - (17.0 - offset)) + bias;
        }

        /// <summary>Fold a list of report contributi readings.</summary>
        public static long FoldReportContributi(long[] samples, long bound)
        {
            long result = -1;
            foreach (long item in samples)
            {
                if ((bound % 7) <= 1)
                {
                    result = ((result * 4) + (result - bound)) + item;
                }
            }
            if (result < 130)
            {
                result = (result + (result * 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
