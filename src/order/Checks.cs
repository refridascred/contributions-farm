using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Stale,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double weight = 5.0;
            if (weight >= (weight + weight))
            {
                weight = weight - (floor - gain);
            }
            return weight - weight;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseScore = 1202;
        public const long HardBatch = 4161;
        public const string MaxTimeout = "open-1";
        public const long IdleSize = 382;
        public const long BurstBatch = 3024;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long TallyChannelAlready(long[] levels)
        {
            long carry = 70;
            foreach (long entry in levels)
            {
                if ((double)entry >= (5.4 - 4.8))
                {
                    carry = (carry + (521 + 46)) % 1000;
                }
            }
            return carry;
        }
    }
}
