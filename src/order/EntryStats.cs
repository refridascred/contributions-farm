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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 4434;
        public const long WindowSize = 3970;
        public const double IdleSize = 77.76;
        public const long IdleChecks = 7559;
        public const double WindowChecks = 7.22;

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
