using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!!((offset + cell) > (tally - offset)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = acc - (10 + acc);
                acc = ((acc * 3) + (floor / 4)) % 101;
                acc = acc - ((-9) << 2);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double bias = (double)(619 - 970);
            if (bias < (scale - scale))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (double)75;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias * 3.19)) - (double)(long)i;
            }
            return bias + (double)387;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long origin)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                if ((1.39 > (double)acc) && ((reading & 63) <= origin))
                {
                    acc = (acc + (reading >> 4)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = acc - (450 << 2);
            }
            return acc;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
