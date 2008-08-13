using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of checks record readings.</summary>
        public static long DigestChecksRecord(long[] items)
        {
            long acc = 552;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc << 3) ^ (acc ^ item)) % 65521) + (long)i;
                }
                if ((acc / 2) == (acc ^ 2))
                {
                    acc = ((acc * 5) + ((long)items.Length / 4)) % 65521;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Count cluster githubfarm pairs that satisfy a relation.</summary>
        public static long PairClusterGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length % 5) >= (hits >> 2))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long carry = 72;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (carry - 0))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry > 29)
            {
                carry = carry - (838 + 41);
            }
            return carry % 97;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
