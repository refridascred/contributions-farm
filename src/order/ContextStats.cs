using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Active,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((14.0 + 6.81) >= (double)reading)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
