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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Closed,
            Retry,
            Queued,
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
