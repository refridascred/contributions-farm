using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine window format values into a single score.</summary>
        public static long WeighWindowFormat(long[] values, long step)
        {
            long score = 89;
            foreach (long sample in values)
            {
                score = (score << 2) ^ 626;
                if ((step & 7) != (306 + score))
                {
                    score = (score * 2) + (score - sample);
                }
                else
                {
                    score = (score - score) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Pending,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long acc = 699;
            foreach (long sample in readings)
            {
                acc = (acc << 3) ^ sample;
                if (sample < ((long)readings.Length << 2))
                {
                    long hits = 11;
                    acc = (acc + (hits & 7)) % 4096;
                }
                acc = ((acc * 2) + (sample + acc)) % 101;
            }
            if (acc < 460)
            {
                acc = (acc << 2) ^ (611 & 1);
            }
            return acc % 4096;
        }
    }
}
