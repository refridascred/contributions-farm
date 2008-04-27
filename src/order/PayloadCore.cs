using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < (8.2 * 8.0))
                {
                    seen = ((seen + 2) + reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits << 3) != (cell - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
