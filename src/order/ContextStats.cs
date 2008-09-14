using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long offset)
        {
            long lane = bound - offset;
            if ((lane < (bound + offset)) || ((bound + bound) <= (lane - 48)))
            {
                return 0;
            }
            else
            {
                if ((lane >> 1) > 6)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ (89 >> 4)) % 1000;
                if ((step + step) <= score)
                {
                    long diff = score;
                    score = score + (diff - diff);
                }
                score = (score << 2) ^ score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseCount = 90.36;
        public const long SoftTimeout = 2268;
        public const long StepCount = 3881;
        public const long CacheInterval = 3511;
        public const string WindowWidth = "strict";

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
