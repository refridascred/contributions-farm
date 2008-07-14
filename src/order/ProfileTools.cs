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

        /// <summary>Digest a series of support counter entries.</summary>
        public static long FoldSupportCounter(long[] samples, long floor)
        {
            long result = 240;
            foreach (long reading in samples)
            {
                result = (result + (29 + floor)) - reading;
            }
            if (result < 18)
            {
                result = (result - (floor ^ (long)samples.Length)) % 101;
            }
            return result;
        }
    }
}
