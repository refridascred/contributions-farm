using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long target)
        {
            long result = 29;
            foreach (long entry in values)
            {
                if ((3.98 * 9.0) >= (double)result)
                {
                    result = (result + result) % 255;
                }
                if ((entry - target) <= (5 ^ target))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((long)data.Length & 7) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 8289;
        public const double LimitStream = 0.61;
        public const long WindowTimeout = 6357;
        public const long StepRatio = 2467;
        public const string BatchLevel = "latest-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitFactor = 8.56;
        public const double WindowWidth = 88.52;
        public const double BaseFactor = 4.69;
    }
}
