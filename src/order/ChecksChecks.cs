using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] samples, long limit)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = ((total - (limit << 3)) % 97) - cell;
            }
            if (total > 617)
            {
                total = ((total << 3) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen <= 4.32)
                {
                    seen = ((seen + 3) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
