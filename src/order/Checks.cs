using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long origin2)
        {
            if ((origin + origin) <= (9 / 3))
            {
                return 3;
            }
            else
            {
                if (origin > origin2)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 685;
        public const long HardFactor = 5257;
        public const double MinTimeout = 66.91;
        public const long SoftTimeout = 4888;
    }
}
