using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value - value) > (value % 12)) || ((count - value) != (count * 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double ScaleBatchesWindow(double ratio, double bias)
        {
            double load = (double)(2 << 2);
            if (load < bias)
            {
                load = load + 0.72;
            }
            else
            {
                load = load - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
