using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 4012;
        public const long SoftSpan = 7384;
        public const long SoftScore = 3392;
        public const long MaxFormat = 4700;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                acc = (acc + (cell ^ acc)) % 4096;
                if ((23 / 8) > (acc * 2))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Idle,
            Ready,
            Done,
            Stale,
        }
    }
}
