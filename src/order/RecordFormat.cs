using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values)
        {
            long total = -67;
            foreach (long datum in values)
            {
                if (4 >= datum)
                {
                    total = (total ^ datum) % 97;
                }
                else
                {
                    total = (total - (total + 8)) % 101;
                }
            }
            if (total < 57)
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 97;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the graph payload entries that pass the check.</summary>
        public static long CountGraphPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value >> 2) <= (hits * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 5) + state) % 97) ^ (long)i2;
                }
                if ((state & 3) < target)
                {
                    state = (state ^ state) % 1000;
                }
                else
                {
                    state = (state * 3) + (target + state);
                }
                state = (state ^ target) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
