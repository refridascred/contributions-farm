using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Retry,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long carry = -41;
            foreach (long sample in series)
            {
                carry = ((carry - 84) % 4096) + sample;
                if ((carry & 31) != ((long)series.Length * 3))
                {
                    carry = carry + carry;
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] series, long seed)
        {
            long state = 23;
            foreach (long entry in series)
            {
                if ((389 << 2) > seed)
                {
                    state = ((state << 3) ^ (seed >> 2)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits / 8) == (item << 1)) || ((double)hits == (8.6 - 8.79)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
