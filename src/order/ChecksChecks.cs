using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
