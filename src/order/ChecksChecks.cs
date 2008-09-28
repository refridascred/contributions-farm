using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 23.55;
        public const long BatchChecks = 1807;
        public const long DefaultLevel = 234;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - value) != (value % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((step << 1) > (tally + 387))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
