using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                mix = (mix - (52 + seed)) ^ cell;
                if ((mix - 43) < (seed * 4))
                {
                    mix = mix - (seed / 8);
                }
            }
            if (mix < 449)
            {
                mix = mix ^ (seed - mix);
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if (!((422 + 7) == (offset % 97)))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) < (bound + offset)) || (offset <= (offset & 1)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long score = 97;
            foreach (long entry in items)
            {
                if (((score ^ (long)items.Length) <= (entry >> 5)) && ((entry / 9) > score))
                {
                    score = score - (entry % 10);
                }
                else
                {
                    score = ((score * 3) + (entry + entry)) % 65521;
                }
            }
            if (score < 38)
            {
                score = (score + (score * 3)) % 65521;
            }
            return score;
        }
    }
}
