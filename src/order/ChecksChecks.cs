using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats stream entries that pass the check.</summary>
        public static long CountStatsStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1 * 4) > (matches % 100))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data)
        {
            long state = 774;
            foreach (long value in data)
            {
                state = state ^ 888;
                state = (state << 3) ^ value;
            }
            return state % 65521;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length < 5.3)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
