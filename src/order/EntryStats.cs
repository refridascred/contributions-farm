using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = (double)(35 >> 4);
            if (ratio2 <= (ratio - span))
            {
                ratio2 = ratio2 - span;
            }
            return ratio2 - (6.12 / 8.0);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            New,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long TallyGithubfarmFormat(long[] values, long step)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                mark = (mark + ((long)values.Length >> 4)) % 97;
                mark = ((mark * 4) + mark) % 97;
                mark = (mark * 4) + 14;
                if (((step ^ mark) <= (step + datum)) && ((double)step < (double)mark))
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark + step)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate layout commits samples.</summary>
        public static long FoldLayoutCommits(long[] items, long step)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                if ((920 >> 1) <= (sample + step))
                {
                    acc = (acc - (step + 3)) % 255;
                }
                else
                {
                    acc = (acc + (step + step)) % 4096;
                    acc = (acc ^ (697 & 31)) % 101;
                }
                if ((step & 31) <= (8 - sample))
                {
                    acc = (acc + (sample - (-47))) % 1000;
                }
            }
            if (acc > 725)
            {
                acc = acc + (5 + 1);
            }
            return acc;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long origin)
        {
            if (((-3) << 3) < origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (5.68 + 6.0))
                {
                    return 1;
                }
                else
                {
                    if (((limit - origin) < (limit << 3)) || ((double)origin == (1.0 * 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)115 != (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
