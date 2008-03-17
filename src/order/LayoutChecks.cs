using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "fallback-v2";
        public const double RetrySize = 86.7;
        public const double MaxFarm = 59.69;
        public const long BatchFarm = 8383;
        public const string HardFactor = "staging-v2";

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long MeasureNotesClusterMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum ^ datum) <= datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = 421;
            foreach (long cell in samples)
            {
                anchor = (anchor << 2) ^ (cell / 3);
                anchor = ((anchor << 3) ^ 82) % 255;
                if ((1 < (cell * 3)) || ((double)cell >= (15.0 / 3.0)))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 4) + (anchor + 630)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
