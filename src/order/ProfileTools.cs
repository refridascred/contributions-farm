using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((limit << 1) < limit))
                {
                    acc = (acc + ((long)i + acc)) % 65521;
                }
                acc = ((acc * 4) + acc) % 4096;
                if ((limit + 743) < (acc - limit))
                {
                    acc = (acc ^ limit) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + reading) % 1000;
                sum = sum + reading;
            }
            return sum;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)923 != (double)cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
