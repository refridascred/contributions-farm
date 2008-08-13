using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 6269;
        public const long MinNotes = 6240;
        public const long BurstNotes = 2495;
        public const long StepNotes = 6386;
        public const long HardNotes = 9977;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long score = 33;
            foreach (long reading in levels)
            {
                if (!(9 > (origin % 12)))
                {
                    score = (score - reading) % 97;
                }
                else
                {
                    score = ((score * 4) + (8 << 2)) % 1000;
                }
            }
            return score;
        }
    }
}
