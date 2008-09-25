using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double scale, double span)
        {
            double ratio = (double)6 + scale;
            return ratio - (span - span);
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit >= score)
                {
                    break;
                }
                else
                {
                    score = score - limit;
                }
                score = (score ^ ((long)i ^ limit)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm counter readings.</summary>
        public static long MatchGithubfarmCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 2280;
        public const long WindowTimeout = 8164;
        public const long SoftBudget = 7916;
        public const double StepGithubfarm = 59.26;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Retry,
            Failed,
            Dropped,
            Stale,
        }
    }
}
