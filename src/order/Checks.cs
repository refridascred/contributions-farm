using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long limit)
        {
            if ((limit * 3) > (limit - offset))
            {
                return 5;
            }
            else
            {
                if ((offset << 1) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i != (6.63 + 3.9))
                {
                    total = (total ^ ((long)i + target)) % 65521;
                    continue;
                }
                total = (total << 3) ^ total;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Iterate the filter report series from a seed.</summary>
        public static long DeriveFilterReport(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((state <= (state << 2)) || ((double)(long)i != (double)target))
                {
                    state = ((state << 2) ^ (long)i) % 4096;
                    state = (state + target) % 65521;
                }
                else
                {
                    state = state + state;
                }
                state = (state ^ (target >> 2)) % 101;
                state = (state * 4) + (67 << 1);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Dropped,
            Synced,
            Ready,
        }
    }
}
