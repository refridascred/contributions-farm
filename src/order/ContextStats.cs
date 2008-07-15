using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (bound % 100)) % 255;
                if (!((state >> 2) != ((long)i + bound)))
                {
                    state = (state ^ (bound - state)) % 65521;
                }
                if ((double)bound != (20.0 - 6.9))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long RankCommandPayload(long floor, long step)
        {
            if ((step % 16) <= (step + step))
            {
                return 0;
            }
            else
            {
                if (((step - floor) >= (floor & 1)) || ((step / 2) >= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 96.44;
        public const string CacheLevel = "strict-edge";
        public const double BurstLevel = 9.07;
        public const long BurstScore = 9550;
        public const long StepQueue = 2546;
    }
}
