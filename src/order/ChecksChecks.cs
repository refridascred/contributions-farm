using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double gain = (floor * 7.0) / 8.0;
            if (gain >= floor)
            {
                gain = gain + (floor * 5.3);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (gain * 5.14);
        }
    }
}
