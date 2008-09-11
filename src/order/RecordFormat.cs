using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate checks layout samples.</summary>
        public static long WeighChecksLayout(long[] levels)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if (!((reading >> 2) > reading))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                }
                if ((anchor % 2) != (232 - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitFactor = 4076;
        public const double BatchSpan = 9.52;
        public const long LimitGraph = 9453;
        public const long HardGraph = 3946;
        public const long BurstFactor = 176;

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double offset)
        {
            double rate = 3.31 - (0.9 * 9.02);
            return (rate + (rate + scale)) + offset;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
