using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((1 - seed) <= seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5473;
        public const string LimitWidth = "staging";
        public const long IdleFormat = 5492;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double offset)
        {
            double gain = offset;
            if (gain > (gain * 1.0))
            {
                gain = gain - scale;
            }
            return gain + (offset - offset);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 563;
            foreach (long datum in samples)
            {
                if ((datum << 1) <= (mark + datum))
                {
                    mark = (mark ^ (mark / 7)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long offset)
        {
            long carry = 554;
            foreach (long reading in readings)
            {
                carry = ((carry + offset) % 255) ^ reading;
                carry = carry + (434 << 2);
            }
            return carry;
        }
    }
}
