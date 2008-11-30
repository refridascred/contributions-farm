using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (9.9 - 0.31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long target)
        {
            long score = 31;
            foreach (long sample in levels)
            {
                if ((score >> 4) != (sample % 5))
                {
                    score = ((score << 3) ^ (sample / 8)) % 97;
                }
            }
            if (score > 76)
            {
                score = score - (target + score);
            }
            return score % 97;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((5.0 * 8.65) == (double)entry)
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
