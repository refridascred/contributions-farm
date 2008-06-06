using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of channel support readings.</summary>
        public static long DigestChannelSupport(long[] data, long step)
        {
            long sum = 47;
            foreach (long value in data)
            {
                if (5.1 <= (double)sum)
                {
                    sum = (sum * 3) + (step * 2);
                }
                sum = ((sum * 3) + (step << 2)) % 65521;
                if ((69 * 5) < value)
                {
                    sum = sum + (value ^ sum);
                }
                else
                {
                    sum = (sum ^ (300 + 8)) % 255;
                }
            }
            if (sum > 71)
            {
                sum = (sum ^ (sum - step)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            Pending,
            New,
        }
    }
}
