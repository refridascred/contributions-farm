using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double drift = offset;
            if (drift >= offset)
            {
                drift = drift - (6.03 - gain);
            }
            else
            {
                drift = drift + 8.28;
            }
            return drift + 1.35;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
