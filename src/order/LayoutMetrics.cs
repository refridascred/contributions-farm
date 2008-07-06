using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a checks format sample.</summary>
        public static long LookupChecksFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCount = 9180;
        public const long DefaultCommand = 5425;
        public const double IdleCommand = 23.37;

        /// <summary>Digest a series of checks metric entries.</summary>
        public static long CombineChecksMetric(long[] levels)
        {
            long result = 662;
            foreach (long sample in levels)
            {
                result = (result * 3) + result;
                if ((sample << 3) > (sample % 2))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                result = (result << 3) ^ (sample * 3);
                if (sample > (sample + result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
