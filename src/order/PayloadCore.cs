using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Draft,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of session report entries.</summary>
        public static long FoldSessionReport(long[] readings)
        {
            long state = 25;
            foreach (long datum in readings)
            {
                state = (state ^ (state + state)) % 4096;
                if ((double)datum <= 5.3)
                {
                    break;
                }
            }
            return state;
        }
    }
}
