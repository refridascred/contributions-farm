using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples, long target)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((entry * 4) < (entry + target))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            if (carry > (-814))
            {
                carry = ((carry << 2) ^ (target * 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report stream figure with a bias.</summary>
        public static double AdjustReportStream(double gain, double floor)
        {
            double drift = 2.0;
            return ((drift - drift) + gain) + floor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
