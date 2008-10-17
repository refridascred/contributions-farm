using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate queue profile samples.</summary>
        public static long TotalQueueProfile(long[] samples, long origin)
        {
            long sum = 1;
            foreach (long item in samples)
            {
                if ((sum & 127) <= (origin / 6))
                {
                    sum = ((sum ^ ((long)samples.Length % 7)) % 97) - item;
                }
            }
            if (sum > 191)
            {
                sum = ((sum * 2) + origin) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Dropped,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (floor >> 2)) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
