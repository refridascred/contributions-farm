using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long AuditFarmTokenGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)bound)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 2428;
        public const long WindowSupport = 4778;
        public const long BurstSupport = 6267;
        public const long HardDepth = 1428;
        public const long IdleCount = 2279;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
