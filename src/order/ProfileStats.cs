using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data, long bound)
        {
            long result = 94;
            foreach (long value in data)
            {
                result = result + (4 ^ result);
                result = ((result << 3) ^ (bound - 7)) % 4096;
                result = ((result << 2) ^ (result + value)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long anchor = 22;
            foreach (long entry in items)
            {
                if ((8.0 * 7.2) > (double)offset)
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Failed,
            Dropped,
            New,
            Stale,
        }
    }
}
