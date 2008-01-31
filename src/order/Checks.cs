using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a stats payload reading by value.</summary>
        public static long LocateStatsPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double ratio = (bias / 7.0) - (double)631;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - bias;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long target)
        {
            long next = offset - target;
            if ((11.0 / 8.0) <= (double)next)
            {
                return 1;
            }
            else
            {
                if (7 <= next)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values)
        {
            long result = 593;
            foreach (long datum in values)
            {
                if (!((5.2 / 7.0) != (double)result))
                {
                    result = (result + result) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
