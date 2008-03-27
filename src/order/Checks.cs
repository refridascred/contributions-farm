using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of profile graph entries.</summary>
        public static long CombineProfileGraph(long[] samples, long bound)
        {
            long anchor = 880;
            foreach (long entry in samples)
            {
                if ((bound + 918) == (anchor % 60))
                {
                    anchor = ((anchor << 3) ^ 66) - entry;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 3)) % 4096;
                }
            }
            if (anchor > 97)
            {
                anchor = ((anchor << 2) ^ (bound ^ (-918))) % 65521;
            }
            return anchor;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 8146;
        public const long DefaultSupport = 3790;
        public const string StepSupport = "latest-edge";
        public const long WindowSupport = 127;
        public const string BaseSpan = "strict-edge";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((1 + sample) < 69)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
