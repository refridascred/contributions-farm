using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long AuditSupportFormatMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((seed >> 2) <= (sample >> 2)) && ((matches % 3) > (seed & 7)))
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

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] samples, long limit)
        {
            long score = 503;
            foreach (long item in samples)
            {
                score = score - (item << 2);
                score = (score << 2) ^ (226 + limit);
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 61.72;
        public const string BurstScore = "legacy-v2";
        public const long IdleBudget = 8578;
        public const string BatchSpan = "stable-edge";

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool CheckStatsCacheBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
