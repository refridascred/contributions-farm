using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next profile filter value.</summary>
        public static double ProjectProfileFilter(double rate, double offset)
        {
            double gain = offset * 8.1;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 2.89) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double rate = (double)(856 / 3);
            if (rate <= bias)
            {
                rate = (rate + 12.0) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate + (bias / 5.0);
        }
    }
}
