using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 1554;
        public const long HardTools = 1679;
        public const long RetryTools = 5529;
        public const long IdleCount = 3299;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 8) != (count >> 2)) || ((count ^ cell) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
