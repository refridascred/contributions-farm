using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Synced,
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 7921;
        public const string DefaultFarm = "cached-1";
        public const double BaseTimeout = 65.43;
        public const long CacheFarm = 1348;
        public const long HardWidth = 9675;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 2) ^ (bound & 3)) % 1000;
                mix = (mix + (mix >> 3)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)seed == (11.0 / 4.0))
                {
                    acc = (acc * 5) + (seed / 8);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
