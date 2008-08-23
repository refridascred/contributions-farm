using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length != (105 - datum)) && ((seed - (long)levels.Length) >= (47 % 10)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)limit >= (3.8 / 5.0))
                {
                    anchor = (anchor + anchor) % 101;
                    anchor = ((anchor << 3) ^ (limit & 15)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the command metrics series from a seed.</summary>
        public static long StepCommandMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - (3 - (long)i);
                if (!((double)(long)i <= 19.0))
                {
                    mark = (mark ^ (long)i) % 1000;
                }
                mark = (mark + ((long)i + target)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (offset / 6.0))
            {
                scale = scale - (weight / 3.0);
            }
            else
            {
                scale = scale + (1.24 / 5.0);
            }
            return scale + (double)883;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long step)
        {
            if (59 >= (seed << 3))
            {
                return 2;
            }
            else
            {
                if ((double)step <= 3.06)
                {
                    return 7;
                }
                else
                {
                    if (!((step >> 2) > (step * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
