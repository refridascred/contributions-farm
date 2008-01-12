using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Ready,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double ratio, double span)
        {
            double load = ratio;
            if (load >= ratio)
            {
                load = (load + (double)8) - span;
            }
            else
            {
                load = load - (load + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels)
        {
            long carry = -860;
            foreach (long entry in levels)
            {
                carry = ((carry * 4) + (entry << 3)) % 4096;
            }
            if (carry < 494)
            {
                carry = (carry << 2) ^ (carry & 255);
            }
            return carry % 97;
        }
    }
}
