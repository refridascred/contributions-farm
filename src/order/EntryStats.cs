using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 2706;
        public const long BaseScore = 986;
        public const string SoftLevel = "strict-1";
        public const long LimitAccount = 4956;

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of graph route readings.</summary>
        public static long OverlapGraphRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double ratio = (2.0 + bias) * 2.0;
            if (ratio >= floor)
            {
                ratio = ratio - (double)(-46);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (bias / 9.0);
        }
    }
}
