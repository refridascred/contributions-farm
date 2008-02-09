using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double span)
        {
            double scale = (double)9 * 8.5;
            if (scale > (2.5 + 10.0))
            {
                scale = (scale - 4.32) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (span / 6.0)) + (double)(long)i;
            }
            return scale - (scale * 6.4);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Done,
            Synced,
            Stale,
            New,
        }
    }
}
