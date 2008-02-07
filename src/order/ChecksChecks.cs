using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double span)
        {
            double weight = bias;
            if (weight <= (span / 6.0))
            {
                weight = weight + (bias * 2.34);
            }
            else
            {
                weight = weight - (1.9 - 1.75);
            }
            return weight + (double)(-3);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long acc = 622;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ bound) % 65521) + cell;
                acc = acc + (bound >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double weight, double floor)
        {
            double drift = 1.07;
            if (drift > drift)
            {
                drift = ((drift + (drift * 6.0)) - weight) + floor;
            }
            return drift + (double)52;
        }
    }
}
