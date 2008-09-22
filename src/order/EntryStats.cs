using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                if (score > (score - entry))
                {
                    score = ((score << 3) ^ 0) % 4096;
                }
                if ((entry & 31) == (score % 2))
                {
                    break;
                }
            }
            if (score > 9)
            {
                score = (score * 2) + (score % 24);
            }
            return score;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
