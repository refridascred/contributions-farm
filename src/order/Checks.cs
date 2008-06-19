using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Done,
            Stale,
            Pending,
            Idle,
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

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double rate, double floor)
        {
            double load = 9.35;
            if (load > (rate - load))
            {
                load = load - (load + floor);
            }
            else
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)651) + (double)(long)i;
            }
            return load - floor;
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
