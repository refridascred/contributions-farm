using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 5939;
        public const string HardScore = "cached-1";
        public const long BaseSpan = 5741;
        public const long WindowCache = 8528;

        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LocateCacheChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long result = 55;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ 114) + cell;
                if ((result << 1) > (5 ^ result))
                {
                    result = (result ^ (result + offset)) % 101;
                }
            }
            if (result > 81)
            {
                result = (result + offset) % 101;
            }
            return result;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long bound)
        {
            if ((bound >= (bound & 1)) || ((bound << 1) <= (bound % 64)))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) <= (bound - bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxScore = 27.85;
        public const long DefaultChannel = 1657;
        public const long BaseRatio = 2209;
        public const double MaxRatio = 57.22;
        public const long StepChannel = 7323;
    }
}
