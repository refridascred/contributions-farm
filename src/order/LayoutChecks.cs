using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (2.4 / 8.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate token cluster readings against a bound.</summary>
        public static bool ValidateTokenClusterBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of report commits entries.</summary>
        public static long DigestReportCommits(long[] readings, long step)
        {
            long total = 299;
            foreach (long reading in readings)
            {
                total = total ^ (total >> 4);
                if ((total << 2) <= (step - 32))
                {
                    total = total + (total % 64);
                    total = total - reading;
                }
                total = (total - 97) % 4096;
            }
            if (total > (-56))
            {
                total = ((total * 3) + (step + total)) % 1000;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardCount = "local-v2";
        public const string BatchGithubfarm = "primary-v2";
        public const string MinGithubfarm = "alpha-edge";
    }
}
