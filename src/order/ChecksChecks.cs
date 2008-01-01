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

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-1";
        public const long DefaultContext = 7734;
        public const double BurstBudget = 24.06;
        public const double IdleContext = 17.11;

        /// <summary>Define already limits and defaults.</summary>
        public const double MinCount = 11.03;
        public const long BaseAlready = 6920;
        public const long IdleAlready = 6834;
        public const long SoftAlready = 3005;
    }
}
