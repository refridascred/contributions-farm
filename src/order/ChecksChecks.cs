using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many report batch samples are out of range.</summary>
        public static long CountReportBatchMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-193) < datum) || ((seen + 60) >= (seen + datum)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile notes figure with a bias.</summary>
        public static double SmoothProfileNotes(double bias, double span)
        {
            double bias2 = span;
            if (bias2 >= (double)8)
            {
                bias2 = (bias2 - (2.7 / 6.0)) - bias;
            }
            return bias2 - (double)4;
        }
    }
}
