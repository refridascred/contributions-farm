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

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i ^ step) <= (total + step)) && ((total - (long)i) <= (step - total)))
                {
                    total = (total - ((long)i / 9)) % 65521;
                }
                total = ((total << 3) ^ total) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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
