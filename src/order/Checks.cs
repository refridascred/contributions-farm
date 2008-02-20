using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a report checks reading.</summary>
        public static double ScaleReportChecks(double scale, double floor)
        {
            double weight = (floor * 3.24) + 8.0;
            if (weight >= (scale + floor))
            {
                weight = weight + (floor - scale);
            }
            else
            {
                weight = weight + floor;
            }
            return weight - (scale - weight);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinBudget = 2131;
        public const double HardPayload = 75.05;
        public const string IdleFactor = "primary-v2";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Stale,
            New,
            Failed,
        }
    }
}
