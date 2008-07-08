using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 98.95;
        public const double MaxInterval = 48.64;
        public const long SoftBatch = 1222;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long sum = 456;
            foreach (long reading in readings)
            {
                if ((sum / 6) <= (reading * 4))
                {
                    sum = (sum * 5) + (sum << 2);
                }
            }
            if (sum < 40)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many stream channel samples are out of range.</summary>
        public static long TallyStreamChannelMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (origin < (origin & 63))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
