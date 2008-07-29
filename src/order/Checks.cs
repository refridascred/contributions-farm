using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 5) < (datum % 64))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                bool valid = (double)sum < 19.0;
                if (valid)
                {
                    valid = (long)i <= origin;
                }
                if ((18.0 < (double)origin) && ((12.0 - 3.0) <= (double)sum))
                {
                    sum = sum ^ (76 >> 2);
                    valid = (origin + 98) != ((long)i + 1);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double bias2 = bias - (double)(-120);
            if (bias2 < floor)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            return bias2 + (double)2;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long step)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (result + (cell << 3)) % 4096;
            }
            if (result > 260)
            {
                result = (result ^ step) % 4096;
            }
            return result;
        }
    }
}
