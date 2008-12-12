using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (10.0 < (double)entry)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowTimeout = "staging";
        public const long DefaultQueue = 4657;
        public const long LimitQueue = 1903;
        public const double CacheQueue = 30.74;

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowDepth = 7441;
        public const long MinSupport = 3305;
        public const double BurstDepth = 11.24;
        public const double DefaultSupport = 57.38;

        /// <summary>Project the next record buffer value.</summary>
        public static double SmoothRecordBuffer(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = ratio + (floor - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 1.4);
        }
    }
}
