using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster farm series from a seed.</summary>
        public static long SeriesClusterFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 5) + (sum % 97)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items)
        {
            long sum = 99;
            foreach (long entry in items)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > (-35))
            {
                sum = sum - sum;
            }
            return sum % 97;
        }
    }
}
