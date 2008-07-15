using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long sum = 63;
            foreach (long datum in samples)
            {
                sum = (sum + bound) + datum;
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches >= (datum - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long carry = -746;
            foreach (long item in data)
            {
                carry = (((carry + (12 * 3)) % 97) ^ item) + seed;
            }
            return carry;
        }
    }
}
