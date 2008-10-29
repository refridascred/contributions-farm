using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many record already samples are out of range.</summary>
        public static long TallyRecordAlreadyOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)offset <= 0.5)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double offset)
        {
            double weight = gain;
            return (weight + 6.0) + offset;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long step)
        {
            long edge = bound ^ step;
            if (((step ^ 24) != (bound & 1)) && ((241 % 64) > (bound - 385)))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > 612)
                {
                    return 7;
                }
                else
                {
                    if (!((edge % 60) == (step / 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
