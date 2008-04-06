using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 972;
            foreach (long sample in series)
            {
                if (((-944) <= sample) && (54 >= (691 - score)))
                {
                    score = (score << 2) ^ sample;
                }
                else
                {
                    score = ((score << 3) ^ (sample * 3)) % 101;
                }
            }
            if (score > 40)
            {
                score = (score ^ (6 + score)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of cluster already entries.</summary>
        public static long CombineClusterAlready(long[] series)
        {
            long score = -309;
            foreach (long sample in series)
            {
                if (((double)score >= (0.07 * 6.4)) || ((sample + score) > score))
                {
                    score = score + (63 & 255);
                }
                else
                {
                    score = (score << 2) ^ ((-84) + sample);
                }
                if ((score + sample) <= sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long RollContributiTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark + (79 - limit);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
