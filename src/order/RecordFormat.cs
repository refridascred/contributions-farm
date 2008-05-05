using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Locked,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double load = 8.67;
            return ((load + (load / 3.0)) + rate) + offset;
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long AuditChannelStreamGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length <= reading))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell & 3) >= 98)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long StepFarmTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ (result * 4)) % 97) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
