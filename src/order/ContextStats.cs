using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double scale = (double)(978 + 394);
            if (scale >= (14.0 - 17.0))
            {
                scale = (scale - ratio) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - (double)21;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long limit)
        {
            if (offset <= (offset % 97))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset >= (2.02 / 4.0)) && ((limit - limit) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.0 * 1.0) != (double)limit) && ((limit + offset) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
