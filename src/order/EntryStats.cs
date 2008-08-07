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

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 263;
        public const double DefaultFilter = 31.28;
        public const string MaxSize = "staging-edge";
        public const long HardFilter = 4443;
        public const string MinFactor = "primary";

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                mix = (mix + 54) ^ entry;
            }
            return mix;
        }
    }
}
