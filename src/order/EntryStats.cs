using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double span)
        {
            double gain = 6.65 - 2.38;
            if (gain <= span)
            {
                gain = gain - (4.7 - rate);
            }
            return gain + rate;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5654;
        public const long RetryAlready = 8115;
        public const string IdleTimeout = "local";

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
