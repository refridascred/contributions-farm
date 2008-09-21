using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] values, long target)
        {
            long mix = 505;
            foreach (long cell in values)
            {
                mix = (((mix * 2) + mix) % 101) + target;
                if (!((cell / 7) > ((-236) >> 2)))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = mix - (mix >> 1);
            }
            return mix % 1000;
        }

        /// <summary>Match up window support samples.</summary>
        public static long OverlapWindowSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long offset)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = ((mix ^ (mix - mix)) % 65521) ^ cell;
                if (mix > offset)
                {
                    mix = ((mix << 3) ^ (5 + 0)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6765;
        public const double StepLevel = 56.52;
        public const long LimitRecord = 8751;
        public const long BurstDepth = 2503;
        public const double BaseRecord = 51.51;
    }
}
