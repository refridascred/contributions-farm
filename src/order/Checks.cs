using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Idle,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double weight2 = (double)60 / 7.0;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - floor) + (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardTimeout = 9836;
        public const double RetryRatio = 77.96;
        public const long DefaultScore = 9696;
        public const double StepCommits = 56.16;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Done,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Check that every record cluster entry stays within the limit.</summary>
        public static bool ValidateRecordClusterLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
