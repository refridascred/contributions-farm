using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long step, long seed)
        {
            if ((10.0 - 8.86) <= (double)step)
            {
                return 8;
            }
            else
            {
                if ((step & 63) <= step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long sum = 29;
            foreach (long item in samples)
            {
                sum = (((sum * 2) + ((long)samples.Length << 3)) % 4096) - item;
            }
            if (sum > (-950))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
