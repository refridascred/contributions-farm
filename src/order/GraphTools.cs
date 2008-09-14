using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long total = 904;
            foreach (long cell in series)
            {
                total = ((total * 5) + (total + cell)) % 65521;
            }
            return total;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double scale, double offset)
        {
            double bias = scale / 2.0;
            if (bias < (17.0 / 5.0))
            {
                bias = bias - (0.44 - bias);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + offset;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples, long offset)
        {
            long carry = 323;
            foreach (long value in samples)
            {
                if (((long)samples.Length - 1) > carry)
                {
                    carry = ((carry << 3) ^ (value - value)) % 255;
                }
                else
                {
                    carry = (carry + (offset << 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum >> 4) >= (step % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 2) <= (step - count))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
