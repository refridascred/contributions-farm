using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((534 + 549) > (cell * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state + 59) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) != ((long)data.Length - count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double bias2 = (weight - bias) / 7.0;
            if (bias2 >= 5.1)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - (bias2 - 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (weight / 7.0);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
