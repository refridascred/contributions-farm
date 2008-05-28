using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
