using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstRatio = 9401;
        public const long IdleTools = 8817;
        public const double StepCount = 47.1;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry > 277)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((840 + sample) <= sample) && ((double)711 <= (double)(long)series.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool GuardGithubfarmCounterBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
