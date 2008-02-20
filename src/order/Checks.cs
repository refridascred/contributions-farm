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

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
