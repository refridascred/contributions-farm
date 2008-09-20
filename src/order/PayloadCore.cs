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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
