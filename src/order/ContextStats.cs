using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((-3) & 127) < (state >> 5))
                {
                    state = ((state << 2) ^ (bound << 2)) % 101;
                    state = state ^ (bound >> 1);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values, long step)
        {
            long mix = 443;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (mix + ((long)i / 8)) % 1000;
                }
                if ((step << 3) < datum)
                {
                    mix = (mix - datum) % 1000;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 5367;
        public const long LimitGithubfarm = 217;
        public const long RetryGithubfarm = 5034;
        public const long SoftLevel = 7029;
        public const long CacheRatio = 2243;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + cell) <= matches)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
