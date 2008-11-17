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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = (result * 2) + item;
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (origin - result)) + (long)i;
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((96 * 5) == (88 ^ result))
                {
                    result = ((result * 3) + (result + 466)) % 1000;
                }
            }
            if (result < 7)
            {
                result = ((result << 2) ^ (origin % 16)) % 4096;
            }
            return result % 65521;
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
