using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the schema window series from a seed.</summary>
        public static long RollSchemaWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total + (14 ^ total)) % 4096) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + 1) <= (cell ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double mean = gain;
            if (mean <= floor)
            {
                mean = mean - (gain / 4.0);
            }
            else
            {
                mean = mean - 8.5;
            }
            return mean - (gain / 5.0);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Done,
            New,
            Pending,
            Failed,
        }
    }
}
