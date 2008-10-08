using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Adjust a cluster batches reading.</summary>
        public static double ScaleClusterBatches(double gain, double offset)
        {
            double drift = (double)750 - offset;
            return (drift - drift) + gain;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Dropped,
            Idle,
            Active,
        }
    }
}
