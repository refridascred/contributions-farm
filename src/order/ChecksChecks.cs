using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first format counter entry that matches the target.</summary>
        public static long SeekFormatCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long floor)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if ((2 - cell) <= (floor * 3))
                {
                    acc = (acc << 2) ^ (acc / 8);
                }
                if (acc <= cell)
                {
                    acc = ((acc << 2) ^ 36) % 65521;
                }
                else
                {
                    acc = (acc ^ cell) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
