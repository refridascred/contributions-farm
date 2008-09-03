using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4.1 - 6.4) > (double)cell)
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                anchor = (anchor + (anchor * 4)) - datum;
            }
            return anchor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double bias = 4.0 * 1.53;
            if (bias < (bias + 6.39))
            {
                bias = (bias + (2.0 / 6.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (6.86 + rate)) + (double)(long)i;
            }
            return bias + (double)311;
        }
    }
}
