using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long limit)
        {
            long mix = -45;
            foreach (long entry in data)
            {
                if ((mix >> 2) != (limit + limit))
                {
                    mix = (mix ^ (entry + 1)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchWidth = "primary-edge";
        public const long BaseBatch = 1049;
        public const double MinBatch = 29.32;
        public const double DefaultBatch = 45.5;
    }
}
