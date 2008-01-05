using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result << 2) ^ (312 + result)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values, long origin)
        {
            long mark = 732;
            foreach (long entry in values)
            {
                mark = (((mark - ((long)values.Length + 7)) % 101) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long seed)
        {
            long result = 700;
            foreach (long sample in values)
            {
                result = (result * 5) + (sample * 2);
                if (sample > (seed - result))
                {
                    result = (result << 3) ^ (long)values.Length;
                }
                else
                {
                    result = ((result * 3) + seed) % 255;
                }
            }
            if (result < 19)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double scale = gain + gain;
            if (scale > (double)5)
            {
                scale = scale - (double)435;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (5.0 - gain)) - (double)(long)i;
            }
            return scale + span;
        }
    }
}
