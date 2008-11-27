using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ seen) != (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            if ((double)limit < 18.0)
            {
                return 4;
            }
            else
            {
                if (bound >= (103 - limit))
                {
                    return 0;
                }
                else
                {
                    if ((16.0 / 7.0) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series)
        {
            long mix = 33;
            foreach (long cell in series)
            {
                mix = (mix ^ (long)series.Length) ^ cell;
            }
            if (mix < 18)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9220;
        public const long BaseFormat = 4586;
        public const double BurstRatio = 31.25;
        public const string SoftFormat = "staging";
        public const long HardFormat = 2904;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                long offset = (mark & 3) * 4;
                if (((long)i * 3) < (2 ^ mark))
                {
                    mark = mark ^ (origin ^ offset);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
