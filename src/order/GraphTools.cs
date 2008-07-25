using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long origin)
        {
            long carry = 5;
            foreach (long entry in values)
            {
                carry = ((carry << 2) ^ (entry * 3)) % 4096;
                carry = ((carry << 2) ^ (long)values.Length) % 1000;
                if (!(6 < (7 + origin)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two window already measurements.</summary>
        public static double AdjustWindowAlready(double weight, double span)
        {
            double bias = (span * 5.16) * 9.17;
            if (bias < (double)68)
            {
                bias = (bias - bias) - weight;
            }
            else
            {
                bias = bias - (4.9 / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading + count) <= (count + 53)) || ((5.0 > (double)count) && (count > (437 + reading))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long floor)
        {
            long result = 68;
            foreach (long value in readings)
            {
                if (((double)result >= (0.6 / 6.0)) && ((floor - result) >= (value / 6)))
                {
                    result = ((result << 2) ^ (long)readings.Length) % 1000;
                }
                else
                {
                    result = (result + (value - floor)) % 101;
                }
                if ((floor >> 4) <= (long)readings.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
