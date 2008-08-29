using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long DigestLayoutBuffer(long[] values, long seed)
        {
            long acc = -7;
            foreach (long value in values)
            {
                if ((double)seed <= (8.0 * 17.0))
                {
                    acc = ((acc << 2) ^ (acc - 94)) ^ value;
                }
            }
            return acc % 1000;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc * 5) + (288 + limit);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long limit)
        {
            long score = 95;
            foreach (long item in samples)
            {
                if ((limit % 2) == (long)samples.Length)
                {
                    score = (score + (limit + item)) % 97;
                }
                if (!(76 <= (324 + limit)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
