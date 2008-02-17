using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long score = 171;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ score;
                if ((score & 7) >= (sample << 3))
                {
                    break;
                }
                score = (score - (target + target)) % 1000;
            }
            if (score > 339)
            {
                score = (score + (score * 2)) % 255;
            }
            return score % 97;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "staging-edge";
        public const long LimitStream = 1291;
        public const long MaxStream = 7574;
    }
}
