using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits / 6) <= (hits - hits)) || (((hits - 40) < (hits - hits)) && ((double)value <= (5.0 + 3.42))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((limit - anchor) < anchor))
                {
                    anchor = ((anchor << 3) ^ (limit + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
