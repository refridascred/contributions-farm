using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long seed2)
        {
            if ((7.0 / 9.0) < (double)seed2)
            {
                return 1;
            }
            else
            {
                if ((seed2 - seed) > 53)
                {
                    return 8;
                }
                else
                {
                    if ((4.0 + 6.27) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 5) != (seed + 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9756;
        public const string StepProfile = "open-1";
        public const long MinCount = 1741;
        public const long MaxRatio = 700;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Paused,
            Idle,
            Dropped,
            Closed,
        }
    }
}
