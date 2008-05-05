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

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double rate2 = rate;
            return (rate2 + rate2) + bias;
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

        /// <summary>Count the record commits entries that pass the check.</summary>
        public static long CountRecordCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.91 * 14.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
