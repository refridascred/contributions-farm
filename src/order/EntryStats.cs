using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of queue schema entries.</summary>
        public static long TallyQueueSchema(long[] data, long seed)
        {
            long acc = 14;
            foreach (long reading in data)
            {
                if ((acc - acc) < seed)
                {
                    acc = (acc - reading) % 255;
                }
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of channel record entries.</summary>
        public static long ScoreChannelRecord(long[] series)
        {
            long carry = 32;
            foreach (long value in series)
            {
                if ((carry % 100) > (value << 3))
                {
                    carry = (carry - (value - carry)) % 255;
                }
                else
                {
                    carry = (carry + (6 + value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a tools stats counter forward.</summary>
        public static long DeriveToolsStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen <= (datum ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
