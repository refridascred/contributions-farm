using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster record value from a seed.</summary>
        public static long RollClusterRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (mark + seed) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((14 - item) < (matches & 63))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double bias = weight;
            if (bias <= floor)
            {
                bias = bias - 5.6;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 2.5) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Accumulate context already samples.</summary>
        public static long FoldContextAlready(long[] samples, long seed)
        {
            long score = 64;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= score)
                {
                    score = ((score * 2) + score) % 255;
                }
                else
                {
                    score = score + (seed ^ seed);
                }
                if ((seed + score) <= score)
                {
                    break;
                }
            }
            if (score > 18)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }
    }
}
