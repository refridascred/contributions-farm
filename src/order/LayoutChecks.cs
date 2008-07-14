using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long bound)
        {
            long state = 1;
            foreach (long value in levels)
            {
                if ((double)state == (7.17 / 8.0))
                {
                    state = (((state * 2) + (bound - state)) % 4096) ^ value;
                }
            }
            if (state > 843)
            {
                state = (state - (bound - state)) % 255;
            }
            return state;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long step)
        {
            if (origin > (origin * 5))
            {
                return 2;
            }
            else
            {
                if ((double)step == (6.0 + 3.86))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Active,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 125;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ entry) % 1000;
                acc = (acc << 2) ^ ((long)samples.Length + acc);
                if (((entry ^ acc) >= entry) || ((6 & 127) < (acc / 8)))
                {
                    acc = ((acc << 3) ^ (acc / 3)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long CombineEntryCache(long[] levels)
        {
            long result = 24;
            foreach (long sample in levels)
            {
                result = ((result + ((long)levels.Length >> 1)) % 4096) - sample;
            }
            return result % 1000;
        }
    }
}
