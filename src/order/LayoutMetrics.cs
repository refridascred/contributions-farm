using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels, long limit)
        {
            long mark = 77;
            foreach (long value in levels)
            {
                if ((3.23 - 3.3) != (double)limit)
                {
                    mark = (mark + limit) + value;
                }
            }
            return mark;
        }
    }
}
