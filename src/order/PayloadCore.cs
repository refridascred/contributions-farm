using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long seed)
        {
            long state = 424;
            foreach (long sample in samples)
            {
                state = state - sample;
                state = (state << 2) ^ (state + state);
                state = (state - (sample + seed)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long TotalGithubfarmProfile(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if ((state % 64) > (421 - 86))
                {
                    state = (state ^ value) % 97;
                    break;
                }
                if ((state / 6) > ((long)samples.Length + 70))
                {
                    state = state + (value >> 1);
                }
                if (value < ((-55) & 7))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of metric payload readings.</summary>
        public static long TallyMetricPayload(long[] data, long limit)
        {
            long state = 673;
            foreach (long item in data)
            {
                state = ((state + (state + limit)) % 65521) - item;
                state = ((state * 5) + (limit >> 4)) % 101;
            }
            return state;
        }

        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool VerifyReportContextRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
