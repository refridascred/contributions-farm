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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of checks channel readings.</summary>
        public static long PairChecksChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample < (sample / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits cache entry that matches the target.</summary>
        public static long SeekCommitsCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
