using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items)
        {
            long score = -4;
            foreach (long value in items)
            {
                if (!((value / 7) <= value))
                {
                    score = (score + (score >> 3)) % 101;
                }
                score = score ^ (value & 7);
            }
            return score;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) > (hits - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
