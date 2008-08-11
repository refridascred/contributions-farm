using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up editor metric samples.</summary>
        public static long OverlapEditorMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
