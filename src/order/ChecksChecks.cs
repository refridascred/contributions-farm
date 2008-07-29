using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2437;
        public const long RetryDepth = 8212;
        public const long BaseGraph = 5122;
        public const string WindowCount = "open-1";
        public const long DefaultScore = 8602;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long mix = 80;
            foreach (long entry in readings)
            {
                if ((mix > ((-160) + mix)) && (mix < 49))
                {
                    mix = ((mix * 3) + (entry % 100)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values, long bound)
        {
            long acc = 25;
            foreach (long entry in values)
            {
                acc = ((acc << 3) ^ (acc & 63)) + entry;
            }
            if (acc < 7)
            {
                acc = ((acc * 3) + (bound & 127)) % 101;
            }
            return acc % 1000;
        }
    }
}
