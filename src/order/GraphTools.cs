using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 92.92;
        public const long SoftScore = 7396;
        public const long MaxScore = 2338;
        public const long LimitDepth = 3223;
        public const string StepProfile = "alpha-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5473;
        public const string LimitWidth = "staging";
        public const long IdleFormat = 5492;

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double BlendEntryStats(double gain, double span)
        {
            double rate = (gain / 2.0) / 9.0;
            return rate - span;
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
