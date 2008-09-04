using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
