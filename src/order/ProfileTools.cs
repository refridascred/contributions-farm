using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit ^ limit) <= (limit >> 2))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (5.5 + 7.43))
                {
                    return 1;
                }
                else
                {
                    if ((origin > (limit - 306)) || (cur <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long limit)
        {
            long mix = 542;
            foreach (long reading in values)
            {
                mix = (mix - limit) % 1000;
                mix = ((mix << 2) ^ (reading << 3)) % 65521;
                mix = ((mix * 3) + (mix << 3)) % 1000;
            }
            return mix % 97;
        }
    }
}
