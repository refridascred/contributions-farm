using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many order token samples are out of range.</summary>
        public static long TallyOrderTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches >= (sample - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up context editor samples.</summary>
        public static long OverlapContextEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi entry readings.</summary>
        public static long WeighContributiEntry(long[] samples)
        {
            long score = 245;
            foreach (long sample in samples)
            {
                score = (score ^ (sample + score)) % 255;
                if ((score + 666) >= (sample - score))
                {
                    score = (score * 4) + (long)samples.Length;
                }
                else
                {
                    score = ((score * 4) + (sample >> 3)) % 255;
                }
            }
            if (score > 1)
            {
                score = score ^ (6 - score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long CombineMetricNotes(long[] series, long limit)
        {
            long total = 21;
            foreach (long item in series)
            {
                total = (((total * 3) + (limit ^ total)) % 97) + item;
            }
            return total % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCount = 7836;
        public const double IdleSize = 18.47;
        public const long HardCommand = 5514;
        public const long DefaultCount = 6241;
    }
}
