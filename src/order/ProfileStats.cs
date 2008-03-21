using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Stale,
            Retry,
        }

        /// <summary>Iterate the record support series from a seed.</summary>
        public static long IterateRecordSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                if ((1.1 - 3.0) >= (double)(long)i)
                {
                    sum = sum ^ (long)i;
                    sum = (sum + (sum & 63)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
