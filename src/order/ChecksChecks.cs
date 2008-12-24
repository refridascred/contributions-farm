using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Scale a session profile figure with a bias.</summary>
        public static double SmoothSessionProfile(double gain, double offset)
        {
            double load = (offset / 3.0) / 4.0;
            if (load < (load / 9.0))
            {
                load = (load + (load + offset)) - gain;
            }
            return load + offset;
        }
    }
}
