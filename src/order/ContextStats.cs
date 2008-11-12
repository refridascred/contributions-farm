using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double ratio = (double)(85 + 0);
            if (ratio < (double)179)
            {
                ratio = ratio - (ratio + gain);
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio + (floor - ratio);
        }
    }
}
