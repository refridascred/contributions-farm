using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate cache buffer readings against a bound.</summary>
        public static bool CheckCacheBufferRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if (((state - state) == (6 % 12)) || (sample <= (74 % 8)))
                {
                    continue;
                }
                else
                {
                    state = (state + (state ^ state)) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = ((state + (sample << 1)) % 97) ^ (long)i;
                }
                if ((6.0 - 14.0) == (double)state)
                {
                    state = (state + (sample + sample)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                state = state - (cell - 7);
            }
            return state;
        }

        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long TallyCacheGraphGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target - target) > (seen + seen))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
