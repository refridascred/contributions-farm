using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((7 ^ value) == (value + 330))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits contributi readings.</summary>
        public static long DigestCommitsContributi(long[] items)
        {
            long mark = 993;
            foreach (long item in items)
            {
                if (7.5 <= (double)mark)
                {
                    mark = ((mark ^ (mark * 4)) % 4096) - item;
                }
            }
            if (mark > 8)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
