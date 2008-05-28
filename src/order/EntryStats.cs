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

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double bias)
        {
            double weight = gain * 8.2;
            if (weight <= bias)
            {
                weight = weight + gain;
            }
            return weight - (double)471;
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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) <= (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
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
