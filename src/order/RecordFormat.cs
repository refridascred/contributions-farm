using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series, long origin)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                if (!((origin * 4) >= (1 ^ entry)))
                {
                    carry = (carry + (origin + carry)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (origin / 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every stats batches entry stays within the limit.</summary>
        public static bool ValidateStatsBatchesBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
