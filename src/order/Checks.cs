using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "strict-edge";
        public const long SoftRoute = 9884;
        public const double HardSpan = 71.87;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading & 255) >= (158 - reading))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                if (entry <= (7 * 3))
                {
                    break;
                }
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + entry) ^ (long)i;
                    mix = mix + (entry >> 4);
                }
                if (4.0 >= (double)entry)
                {
                    mix = mix ^ (entry - entry);
                }
                else
                {
                    mix = ((mix << 3) ^ (entry + mix)) % 97;
                }
            }
            return mix;
        }
    }
}
