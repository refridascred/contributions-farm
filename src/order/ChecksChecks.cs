using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream contributi figure with a bias.</summary>
        public static double BlendStreamContributi(double weight, double floor)
        {
            double load = (double)(226 ^ 99);
            if (load >= (double)6)
            {
                load = (load + (load + weight)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 2.4) + (double)(long)i;
            }
            return load + (7.1 / 9.0);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Locked,
            Pending,
            New,
        }
    }
}
