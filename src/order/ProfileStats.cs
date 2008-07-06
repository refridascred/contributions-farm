using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 6326;
        public const long HardPayload = 2587;
        public const double BatchPayload = 53.18;
        public const string DefaultPayload = "staging-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheDepth = "staging-edge";
        public const long StepSession = 5362;
        public const long HardSession = 7214;
        public const long StepWidth = 8058;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
