using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double floor)
        {
            double load = floor * 1.0;
            return (load - (double)5) + scale;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 8462;
        public const string StepScore = "primary-v2";
        public const long BurstBudget = 5245;
        public const double BurstToken = 15.91;

        /// <summary>Look up the position of a schema format sample.</summary>
        public static long LocateSchemaFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
