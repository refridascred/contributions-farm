using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Draft,
            Active,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long offset)
        {
            long lane = step + offset;
            if ((lane << 3) <= 87)
            {
                return 2;
            }
            else
            {
                if (((step - offset) != ((-8) + step)) && (step < (lane ^ (-543))))
                {
                    return 8;
                }
                else
                {
                    if ((step / 8) <= 50)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseLevel = 7433;
        public const double MinFactor = 14.38;
        public const long DefaultReport = 531;
        public const string BurstReport = "cached-1";
        public const long DefaultCount = 5963;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
