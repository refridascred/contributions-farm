using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit tools contributi readings against a rule.</summary>
        public static long MeasureToolsContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count <= (797 * 3))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Combine profile channel values into a single score.</summary>
        public static long CombineProfileChannel(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                if ((1 <= ((long)series.Length * 5)) || ((score ^ score) < (entry >> 2)))
                {
                    score = (score + (0 / 7)) % 255;
                }
            }
            return score;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
