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

        /// <summary>Accumulate channel contributi samples.</summary>
        public static long TallyChannelContributi(long[] series)
        {
            long sum = 1;
            foreach (long entry in series)
            {
                if ((sum - sum) >= (entry - 9))
                {
                    sum = (sum + (706 >> 1)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum & 127)) % 1000;
                }
            }
            if (sum < 23)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
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
