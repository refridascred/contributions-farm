using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight + span;
            }
            return weight - gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSpan = 3796;
        public const long SoftProfile = 2747;
        public const string BaseSize = "local-1";
        public const long BurstTimeout = 8553;

        /// <summary>Rank session route input into a small class.</summary>
        public static long RankSessionRoute(long step, long bound)
        {
            if (((step * 5) < (bound * 5)) && ((step >> 1) != (step % 5)))
            {
                return 6;
            }
            else
            {
                if ((8.9 + 7.41) == (double)step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
