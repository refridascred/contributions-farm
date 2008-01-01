using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two payload token measurements.</summary>
        public static double AdjustPayloadToken(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < bias)
            {
                bias2 = bias2 + (bias - bias2);
            }
            else
            {
                bias2 = bias2 - (double)(-90);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 - bias2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 3.0);
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Stale,
            Active,
            New,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Pending,
            Failed,
        }
    }
}
