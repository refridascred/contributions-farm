using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (93 / 6)) % 4096;
                if ((double)target >= 2.7)
                {
                    mix = mix + (target & 1);
                }
                if (!((target - target) >= (target & 127)))
                {
                    mix = ((mix * 4) + (mix << 2)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseTimeout = 43.44;
        public const long RetryMetrics = 6824;
        public const double HardMetrics = 61.03;

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long PairQueueCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the commits notes entries that pass the check.</summary>
        public static long CountCommitsNotesHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen < (item - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
