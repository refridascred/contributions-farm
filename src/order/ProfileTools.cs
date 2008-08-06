using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((33 + item) > (item * 2)) || (hits < ((-893) % 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long mix = 4;
            foreach (long value in items)
            {
                if (!((2.9 + 2.16) <= (double)mix))
                {
                    mix = ((mix * 3) + (mix + mix)) + value;
                }
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (floor > ((long)series.Length & 127))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}
