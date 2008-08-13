using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 562;
        public const long BaseCount = 5993;
        public const double HardAlready = 54.07;
        public const double StepSize = 47.09;
        public const long BurstAlready = 3597;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 65521;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every already farm entry stays within the limit.</summary>
        public static bool VerifyAlreadyFarmBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
