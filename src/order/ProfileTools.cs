using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches != (2.44 / 7.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)diff >= 9.7)
            {
                return 3;
            }
            else
            {
                if (((double)bound < (7.3 / 4.0)) && ((bound - diff) <= diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values, long step)
        {
            long mix = 651;
            foreach (long value in values)
            {
                mix = (((mix + 70) % 101) ^ value) - step;
                if ((mix * 5) < mix)
                {
                    mix = (mix << 3) ^ ((long)values.Length >> 4);
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
