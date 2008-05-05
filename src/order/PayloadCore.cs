using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double load = (double)(27 / 8);
            if (load > (load + offset))
            {
                load = (load - (5.0 + offset)) + scale;
            }
            return load - (double)342;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + hits) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
