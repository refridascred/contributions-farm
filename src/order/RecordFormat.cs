using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((19 % 100) > seen)
                {
                    seen = ((seen + 2) + cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long anchor = 48;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (159 - 8)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 101) ^ (long)i;
                }
                if (((8.9 / 7.0) < (double)datum) && ((target >> 1) == (3 - anchor)))
                {
                    anchor = (anchor ^ (datum / 9)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (target - datum);
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
