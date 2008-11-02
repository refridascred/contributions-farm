using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + 9) <= offset)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double bias = 4.5 - floor;
            return bias - rate;
        }

        /// <summary>Iterate the checks editor series from a seed.</summary>
        public static long IterateChecksEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
