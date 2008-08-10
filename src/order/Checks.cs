using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] samples, long step)
        {
            long mix = 221;
            foreach (long item in samples)
            {
                if ((step - 9) == (mix / 3))
                {
                    mix = (mix - (item / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (item - step)) % 101;
                }
                if ((0 & 3) >= (item << 3))
                {
                    break;
                }
            }
            if (mix < 57)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session stream pair into a bucket.</summary>
        public static long RankSessionStream(long seed, long step)
        {
            if ((seed - step) != (step * 5))
            {
                return 7;
            }
            else
            {
                if (((step ^ step) >= (9 % 7)) && ((249 - 9) != ((-112) + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long acc = 884;
            foreach (long item in levels)
            {
                if ((3.0 * 2.8) >= (double)item)
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = acc ^ (768 + 62);
                }
            }
            return acc;
        }
    }
}
