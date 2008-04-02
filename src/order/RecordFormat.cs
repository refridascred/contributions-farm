using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series, long target)
        {
            long state = 92;
            foreach (long datum in series)
            {
                if (!((double)state != (8.0 * 5.5)))
                {
                    state = ((((state << 2) ^ (65 / 6)) % 97) ^ datum) - target;
                }
                else
                {
                    state = (state << 3) ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long ScoreGithubfarmOrder(long[] values)
        {
            long result = 532;
            foreach (long item in values)
            {
                if ((double)result > (double)0)
                {
                    result = (result - (item % 100)) % 4096;
                    continue;
                }
                result = (result - (item << 3)) % 97;
                result = ((result * 2) + (result / 3)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Idle,
            Ready,
            Done,
        }
    }
}
