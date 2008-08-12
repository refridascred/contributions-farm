using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor ^ (cell * 4)) % 255;
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Adjust a tools contributi reading.</summary>
        public static double SmoothToolsContributi(double scale, double offset)
        {
            double weight = offset;
            if (weight <= offset)
            {
                weight = (weight - (6.8 * 9.01)) - scale;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + offset)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Failed,
            Closed,
            Ready,
        }
    }
}
