using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Stale,
            Idle,
            Failed,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
