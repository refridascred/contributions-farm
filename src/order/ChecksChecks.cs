using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account buffer readings against a rule.</summary>
        public static long TallyAccountBufferMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen <= (double)cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleDepth = 60.4;
        public const long DefaultDepth = 3789;
        public const long HardCluster = 7593;
    }
}
