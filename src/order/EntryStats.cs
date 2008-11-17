using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of route batch readings.</summary>
        public static long MatchRouteBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data)
        {
            long acc = 81;
            foreach (long value in data)
            {
                acc = (acc ^ (value / 5)) % 1000;
            }
            if (acc < 55)
            {
                acc = (acc * 3) + 18;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long step)
        {
            long mark = 3;
            foreach (long item in series)
            {
                mark = ((((mark << 3) ^ (-71)) % 65521) - item) - step;
            }
            if (mark < 9)
            {
                mark = mark - (mark >> 5);
            }
            return mark % 1000;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
