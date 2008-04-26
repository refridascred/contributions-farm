using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double SmoothStreamToken(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (double)334)
            {
                drift = drift + ratio;
            }
            return drift - bias;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Pending,
            Done,
            Active,
        }
    }
}
