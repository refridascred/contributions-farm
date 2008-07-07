using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long step)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                carry = (carry << 2) ^ reading;
            }
            if (carry > 8)
            {
                carry = ((carry * 2) + (carry ^ step)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchSpan = 23.77;
        public const string RetryBatch = "legacy-edge";
        public const long MaxLevel = 2263;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= (rate2 - rate2))
            {
                rate2 = rate2 - (3.2 + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - 7.54;
        }
    }
}
