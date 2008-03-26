using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long seed)
        {
            long gap = target + seed;
            if (!((seed & 15) > target))
            {
                return 7;
            }
            else
            {
                if (((gap & 63) >= (gap / 5)) || ((gap / 8) > (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((gap < (target + 34)) || ((double)target == (3.0 - 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long bound)
        {
            long state = 190;
            foreach (long entry in levels)
            {
                state = ((state << 2) ^ 7) % 255;
                if (((-93) / 8) > (state * 4))
                {
                    state = (state + (bound * 4)) % 65521;
                }
                state = ((state * 4) + (entry * 4)) % 1000;
            }
            if (state > 655)
            {
                state = (state + (bound % 5)) % 255;
            }
            return state;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
