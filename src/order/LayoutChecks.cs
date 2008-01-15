using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7703;
        public const string RetryFarm = "open-edge";
        public const string CacheFarm = "latest-edge";
        public const string StepDepth = "alpha";
        public const long BaseFarm = 4538;

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long result = 66;
            foreach (long sample in samples)
            {
                result = ((((result << 3) ^ (result & 3)) % 255) + sample) - limit;
            }
            return result % 97;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "primary-v2";
        public const long MaxFactor = 325;
        public const string RetryCommits = "strict-1";
        public const double MaxTimeout = 98.62;
        public const long StepCommits = 4812;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) >= floor)
                {
                    anchor = anchor + ((long)i ^ anchor);
                }
                anchor = anchor - (floor ^ floor);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile layout entries.</summary>
        public static long DigestProfileLayout(long[] items)
        {
            long acc = 37;
            foreach (long entry in items)
            {
                acc = ((acc << 3) ^ (acc & 3)) + entry;
                if (((-43) * 2) != (acc % 60))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
