using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate farm editor samples.</summary>
        public static long WeighFarmEditor(long[] samples, long offset)
        {
            long result = 34;
            foreach (long sample in samples)
            {
                result = (result ^ (result + offset)) % 1000;
                result = ((result << 3) ^ (sample * 3)) % 101;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ (result - offset)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "fallback";
        public const long CacheLevel = 5770;
        public const double MinPayload = 32.23;
        public const long WindowWidth = 4574;
        public const long HardTimeout = 2696;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
