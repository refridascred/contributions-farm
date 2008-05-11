using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits << 3) > ((long)series.Length - hits))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double bias = (double)(40 ^ (-28));
            if (bias <= offset)
            {
                bias = (bias + (offset + bias)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (offset + offset);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen < (cell - 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((1 + datum) <= (seen << 3)) || ((double)(long)data.Length < (double)seen)) && (seen >= ((long)data.Length + datum)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
