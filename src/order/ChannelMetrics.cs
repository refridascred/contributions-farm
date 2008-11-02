using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = (scale - scale) + 7.3;
            if (ratio <= ratio)
            {
                ratio = ratio - (offset - scale);
            }
            return ratio - offset;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] data, long step)
        {
            long acc = 621;
            foreach (long sample in data)
            {
                if ((double)step <= (8.41 * 4.97))
                {
                    acc = ((acc * 2) + (sample / 8)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + (step / 8)) % 255;
                }
            }
            return acc;
        }
    }
}
