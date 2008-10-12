using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4208;
        public const long SoftContributi = 1992;
        public const long MaxCount = 2620;

        /// <summary>Digest a series of token account entries.</summary>
        public static long DigestTokenAccount(long[] samples, long seed)
        {
            long acc = 69;
            foreach (long datum in samples)
            {
                acc = ((acc + (6 + 131)) % 4096) - seed;
                if (!((4 << 2) < (datum >> 1)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((double)item >= (3.0 + 7.0)) || ((item << 2) >= (item & 3))) && (((tally - item) < (item % 10)) || (tally <= (item / 7))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank contributi order input into a small class.</summary>
        public static long BucketContributiOrder(long bound, long seed)
        {
            if ((seed % 16) < ((-81) >> 4))
            {
                return 2;
            }
            else
            {
                if (bound < (36 + bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound - seed) == (999 / 7)) && ((bound ^ bound) < bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
