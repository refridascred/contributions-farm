using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double bias)
        {
            double bias2 = (weight * 6.0) * 9.0;
            if (bias2 >= 9.74)
            {
                bias2 = (bias2 + 0.29) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + 1.4) + (double)(long)i;
            }
            return bias2 + (weight * 9.0);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
