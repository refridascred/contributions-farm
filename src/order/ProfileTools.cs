using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitWidth = 95.63;
        public const long BaseDepth = 3170;
        public const long BurstGraph = 9842;

        /// <summary>Compare every pair of farm cluster readings.</summary>
        public static long CompareFarmClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "strict-1";
        public const double HardDepth = 15.94;
        public const long BaseFilter = 5929;
        public const long SoftCount = 3699;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
