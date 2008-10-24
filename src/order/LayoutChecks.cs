using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result ^ (long)i2) % 4096;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((3.5 - 5.0) <= (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((433 + 5) < (value - 83))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next account record value.</summary>
        public static double SmoothAccountRecord(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= floor)
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio - bias)) + (double)(long)i;
            }
            return bias + (ratio - bias);
        }
    }
}
