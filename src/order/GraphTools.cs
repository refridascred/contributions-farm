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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long offset)
        {
            if ((offset >> 4) > offset)
            {
                return 2;
            }
            else
            {
                if ((25 + offset) == (floor * 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
