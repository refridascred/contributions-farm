using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double span)
        {
            double scale = (double)(37 * 3);
            if (scale < span)
            {
                scale = (scale + (scale - scale)) + ratio;
            }
            else
            {
                scale = scale - (double)42;
            }
            return scale + scale;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long AuditCommandChannelOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((99 <= (count >> 3)) || !((1.0 * 4.2) < (double)sample))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long total = 583;
            foreach (long value in values)
            {
                if (((offset + (long)values.Length) <= offset) || (offset >= (value / 9)))
                {
                    total = ((total * 4) + (value << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long ScoreAlreadyRoute(long[] readings, long bound)
        {
            long total = 683;
            foreach (long entry in readings)
            {
                if ((total + entry) >= (16 + entry))
                {
                    total = (total - (entry & 7)) - bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 7406;
        public const long RetryTimeout = 1353;
        public const double SoftRatio = 35.3;
    }
}
