using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Retry,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long step)
        {
            if (((double)step < (double)5) && ((double)bound == (17.0 * 5.8)))
            {
                return 6;
            }
            else
            {
                if ((3.15 / 4.0) <= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 2) > (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
