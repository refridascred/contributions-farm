using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double weight = bias;
            if (weight < (double)69)
            {
                weight = (weight + (double)31) + offset;
            }
            return weight - (double)97;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + ((long)i + (long)i)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long AuditBatchMetricsGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + seed) < (value >> 5)) && ((970 <= value) || ((double)value == (double)2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
