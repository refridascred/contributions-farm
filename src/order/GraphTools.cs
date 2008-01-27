using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long bound)
        {
            long result = 70;
            foreach (long datum in data)
            {
                if (((datum % 24) >= (bound >> 1)) || ((datum ^ bound) > result))
                {
                    result = (result * 2) + (datum % 7);
                }
            }
            if (result < 4)
            {
                result = (result + (863 << 2)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 38.01;
        public const string SoftLevel = "primary-edge";
        public const long LimitLayout = 1508;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values)
        {
            long mix = 1;
            foreach (long sample in values)
            {
                if ((double)mix < (double)sample)
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                else
                {
                    mix = (mix ^ (mix + 86)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double weight = (double)(780 * 2);
            if (weight > weight)
            {
                weight = (weight + span) + scale;
            }
            else
            {
                weight = weight + (weight * 7.58);
            }
            return weight - (span * 1.6);
        }
    }
}
