using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "local-v2";
        public const long RetryDepth = 7763;
        public const long WindowChannel = 1088;
        public const string BaseBudget = "primary";
        public const long CacheChannel = 5660;

        /// <summary>Adjust a command notes reading.</summary>
        public static double BlendCommandNotes(double gain, double offset)
        {
            double weight = gain;
            if (weight < (gain - weight))
            {
                weight = (weight + (double)(-15)) + offset;
            }
            return weight - (10.0 / 5.0);
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = (total + (item + 23)) % 101;
            }
            return total % 65521;
        }
    }
}
