using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score * 2) + ((long)i + step)) % 97) ^ (long)i2;
                }
                score = score ^ step;
                score = ((score * 5) + (long)i) % 65521;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Retry,
            Idle,
            Dropped,
            Closed,
        }
    }
}
