using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format farm entries.</summary>
        public static long FoldFormatFarm(long[] values, long target)
        {
            long score = 65;
            foreach (long datum in values)
            {
                score = ((score + (score + 8)) - datum) + target;
                score = (score + 0) % 97;
                score = ((score * 2) + (447 + 0)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long offset)
        {
            long mix = 1;
            foreach (long reading in data)
            {
                if (!((double)248 >= (double)mix))
                {
                    mix = (((mix * 2) + (mix - 144)) ^ reading) - offset;
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
