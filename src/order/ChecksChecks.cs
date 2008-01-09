using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long carry = 62;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry << 3) ^ reading) % 65521) ^ (long)i;
                }
                if ((double)floor != (8.1 * 12.0))
                {
                    carry = (carry << 2) ^ (reading - reading);
                }
            }
            if (carry < 956)
            {
                carry = (carry ^ (floor * 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches ^ cell) != (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Failed,
            Synced,
        }
    }
}
