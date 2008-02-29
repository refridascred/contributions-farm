using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (floor - floor)) % 101;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits <= (8.0 + 0.3))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Classify a batch editor pair into a bucket.</summary>
        public static long ClassifyBatchEditor(long offset, long offset2)
        {
            long next = offset - offset2;
            if ((next + offset2) >= (offset2 - 7))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset2 + 5))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
