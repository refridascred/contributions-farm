using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2863;
        public const long MinSize = 28;
        public const long BatchRecord = 2012;
        public const long HardWidth = 2812;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result * 5) + 878;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
