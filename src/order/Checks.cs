using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate editor account samples.</summary>
        public static long CombineEditorAccount(long[] samples, long seed)
        {
            long mix = 31;
            foreach (long datum in samples)
            {
                mix = (mix << 2) ^ seed;
                mix = (mix * 4) + (datum & 63);
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm schema samples are out of range.</summary>
        public static long CountGithubfarmSchemaMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((offset + seen) <= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes commits samples.</summary>
        public static long ScoreNotesCommits(long[] series)
        {
            long carry = 626;
            foreach (long value in series)
            {
                carry = ((carry * 4) + carry) % 101;
                if ((double)(long)series.Length < (double)carry)
                {
                    carry = ((carry * 4) + (value ^ value)) % 255;
                }
                else
                {
                    carry = ((carry * 5) + (218 + value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 7374;
        public const string BaseStream = "fallback-1";
        public const long BaseWidth = 3815;
        public const double WindowStream = 7.39;
        public const long CacheStream = 8883;
    }
}
