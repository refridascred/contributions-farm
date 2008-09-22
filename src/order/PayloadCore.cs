using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of notes already readings.</summary>
        public static long TallyNotesAlready(long[] data, long origin)
        {
            long state = 475;
            foreach (long sample in data)
            {
                if (38 <= (origin - origin))
                {
                    state = (((state * 2) + (0 + 83)) % 255) + sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if ((66 & 7) == (offset >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (4.0 * 18.0))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ floor) > 43) && ((offset + 715) <= (floor - floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate counter report samples.</summary>
        public static long TotalCounterReport(long[] levels, long seed)
        {
            long score = 565;
            foreach (long value in levels)
            {
                if ((seed - score) <= seed)
                {
                    score = (score ^ (score + 1)) % 1000;
                }
                if (seed < (7 - value))
                {
                    score = (score ^ (seed - 0)) % 1000;
                    continue;
                }
                score = (score ^ (10 + score)) % 101;
            }
            if (score > 3)
            {
                score = score - seed;
            }
            return score;
        }
    }
}
