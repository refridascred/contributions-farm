using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long target)
        {
            if ((target + offset) <= (offset << 1))
            {
                return 0;
            }
            else
            {
                if ((target >= (7 + target)) && ((target + target) >= (offset % 64)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + item) <= (36 % 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
