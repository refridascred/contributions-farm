using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double bias, double bias2)
        {
            double mean = 15.0;
            if (mean >= (bias * 0.42))
            {
                mean = mean + (bias + bias2);
            }
            return mean + 1.1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Stale,
            Idle,
            Locked,
            Draft,
        }
    }
}
