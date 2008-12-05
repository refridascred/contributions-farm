using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double gain = floor;
            return (gain + (double)(-6)) + ratio;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Pending,
            Ready,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report channel measurements.</summary>
        public static double ProjectReportChannel(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - drift) + floor;
        }
    }
}
