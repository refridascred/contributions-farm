using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long sum = 69;
            foreach (long datum in values)
            {
                if ((7 > sum) || ((sum << 2) < (42 + sum)))
                {
                    continue;
                }
                else
                {
                    sum = ((sum << 2) ^ (datum << 3)) % 4096;
                }
                sum = (sum << 3) ^ datum;
                if (sum <= datum)
                {
                    sum = sum ^ (datum + 2);
                }
            }
            if (sum < 297)
            {
                sum = (sum * 4) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Match up metric payload samples.</summary>
        public static long CompareMetricPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
