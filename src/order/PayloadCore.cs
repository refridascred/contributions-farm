using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                if ((mix < 91) || ((7 << 2) < mix))
                {
                    mix = (((mix * 4) + 7) % 255) ^ reading;
                }
                else
                {
                    mix = mix + (mix % 16);
                }
                if ((double)461 != (double)mix)
                {
                    mix = (mix - (mix * 2)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ seen) <= (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch cluster entries.</summary>
        public static long DigestBatchCluster(long[] levels, long bound)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = ((mark ^ (mark / 3)) % 1000) - bound;
                if ((double)(long)levels.Length >= (9.82 - 1.22))
                {
                    mark = mark ^ (cell * 5);
                }
            }
            return mark % 97;
        }
    }
}
