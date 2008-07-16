using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long seed)
        {
            long acc = 54;
            foreach (long reading in samples)
            {
                acc = ((((acc * 3) + (acc + acc)) % 4096) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long limit)
        {
            long anchor = 121;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (limit + anchor)) % 65521) - reading;
            }
            return anchor;
        }

        /// <summary>Fold a list of farm counter readings.</summary>
        public static long CombineFarmCounter(long[] readings)
        {
            long state = -597;
            foreach (long entry in readings)
            {
                state = ((state - state) % 97) - entry;
            }
            return state % 65521;
        }
    }
}
