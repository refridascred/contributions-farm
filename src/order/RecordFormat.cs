using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score * 2) + (sample - limit)) + (long)i;
                }
                if (limit >= (limit * 2))
                {
                    score = (score ^ score) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            New,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route context values into a single score.</summary>
        public static long TallyRouteContext(long[] samples)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                if ((state < (state >> 1)) || ((5.4 + 7.61) > (double)state))
                {
                    state = (state + (entry >> 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
        }
    }
}
