using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (58 > (reading + reading))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long seed)
        {
            long mix = 585;
            foreach (long sample in data)
            {
                mix = (((mix * 3) + (mix * 4)) ^ sample) + seed;
            }
            return mix;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultRatio = 1803;
        public const long DefaultFilter = 4332;
        public const long IdleFilter = 8711;
        public const double StepWidth = 59.73;
        public const long LimitFilter = 4346;
    }
}
