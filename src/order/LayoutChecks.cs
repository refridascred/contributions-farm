using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a format queue reading.</summary>
        public static double ProjectFormatQueue(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)59)
            {
                ratio = (ratio - scale) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 3071;
        public const double LimitLevel = 62.93;
        public const long BurstScore = 13;
        public const string LimitCluster = "strict-1";
        public const long BaseCluster = 2602;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long mark = 817;
            foreach (long reading in readings)
            {
                if ((mark % 24) == (53 * 4))
                {
                    mark = (mark - reading) % 101;
                }
                else
                {
                    mark = (mark - (reading + mark)) % 101;
                }
            }
            if (mark > 1)
            {
                mark = (mark - ((long)readings.Length - 691)) % 255;
            }
            return mark;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 97) >= matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1182;
        public const long BatchSpan = 7865;
        public const string SoftBudget = "cached-v2";
    }
}
