using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool GuardProfileRouteLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next graph payload value.</summary>
        public static double BlendGraphPayload(double scale, double bias)
        {
            double scale2 = scale + bias;
            if (scale2 >= scale2)
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (scale2 / 3.0)) - (double)(long)i;
            }
            return scale2 - (scale2 + bias);
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
