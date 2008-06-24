using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((sum ^ origin) <= 881)
                {
                    sum = sum ^ (sum - (long)i);
                    sum = ((sum * 4) + (sum - origin)) % 255;
                }
                long offset = sum;
                if ((((long)i * 3) == (offset - origin)) && (((long)i + (long)i) < offset))
                {
                    sum = ((sum * 5) + offset) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (limit < (matches >> 1))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
