using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit already stream readings against a rule.</summary>
        public static long CountAlreadyStreamHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > 9)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry & 31) <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long StepGraphCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
