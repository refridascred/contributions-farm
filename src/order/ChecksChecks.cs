using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double load = bias;
            if (load > rate)
            {
                load = load + bias;
            }
            return load - (double)(-45);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Pending,
            Retry,
            Done,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinCount = 11.03;
        public const long BaseAlready = 6920;
        public const long IdleAlready = 6834;
        public const long SoftAlready = 3005;
    }
}
