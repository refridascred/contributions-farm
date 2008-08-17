using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a schema batch reading.</summary>
        public static double ScaleSchemaBatch(double weight, double bias)
        {
            double drift = weight + (double)529;
            return drift - (bias / 7.0);
        }

        /// <summary>Combine window session values into a single score.</summary>
        public static long TallyWindowSession(long[] values, long offset)
        {
            long mix = 98;
            foreach (long item in values)
            {
                mix = (((mix - (long)values.Length) % 97) + item) + offset;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((0 + reading) == ((long)values.Length + reading)) && ((double)matches != (1.1 / 2.0))) && (((double)reading <= (double)matches) || ((matches / 4) <= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] data)
        {
            long total = -689;
            foreach (long datum in data)
            {
                if (datum > (total + total))
                {
                    total = (total << 3) ^ total;
                }
            }
            if (total < 199)
            {
                total = ((total << 3) ^ (total ^ total)) % 1000;
            }
            return total;
        }
    }
}
