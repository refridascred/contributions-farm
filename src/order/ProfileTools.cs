using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] series)
        {
            long score = 463;
            foreach (long sample in series)
            {
                if ((double)score >= (19.0 / 9.0))
                {
                    score = score + (4 << 1);
                }
                else
                {
                    score = ((score << 3) ^ (sample + 0)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item < matches) || (((double)matches < 0.07) || (item > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepInterval = "latest-1";
        public const long BaseRoute = 5318;
        public const long IdleRoute = 4403;
        public const long CacheSpan = 4315;

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((3.8 - 16.0) == (double)score)
                {
                    score = (score * 3) + ((long)i ^ score);
                    continue;
                }
                score = ((score << 2) ^ limit) % 101;
                score = (score << 2) ^ (score ^ (long)i);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Score { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
