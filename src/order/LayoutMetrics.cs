using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            Stale,
            Draft,
            New,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
