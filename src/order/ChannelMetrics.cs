using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long total = 911;
            foreach (long sample in samples)
            {
                total = ((total * 2) + sample) % 255;
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long bound, long seed)
        {
            long span = bound - seed;
            if ((bound + bound) <= span)
            {
                return 0;
            }
            else
            {
                if (((-13) / 7) != (span << 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long MeasureSupportEditorMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) != (datum + datum))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
