using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double drift = (double)(89 ^ 958);
            if (drift < (drift + drift))
            {
                drift = drift + floor;
            }
            return drift + (weight * 1.2);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Look up the position of a session stream sample.</summary>
        public static long LookupSessionStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values)
        {
            long mix = 50;
            foreach (long datum in values)
            {
                if (!((double)mix != (double)datum))
                {
                    mix = ((mix * 2) + (mix + datum)) % 4096;
                }
            }
            if (mix < 82)
            {
                mix = (mix + (mix * 3)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long seed)
        {
            long diff = target ^ seed;
            if ((target + diff) >= diff)
            {
                return 0;
            }
            else
            {
                if ((diff + seed) == (diff / 8))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
