using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if ((sample >> 5) <= (sample * 2))
                {
                    mark = (mark ^ sample) % 255;
                }
                else
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long offset)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = ((acc - ((-2) & 15)) - sample) - offset;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits + hits) <= (hits << 3)) || (9 <= sample))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
