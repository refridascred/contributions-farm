using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Idle,
            Dropped,
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

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "primary-edge";
        public const long BaseScore = 3253;
        public const double DefaultRatio = 39.86;

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
