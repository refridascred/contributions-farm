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

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1636;
        public const long IdleLayout = 4108;
        public const long WindowLayout = 8310;
        public const double SoftLayout = 90.36;
        public const long CacheLayout = 6948;

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
