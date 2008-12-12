using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Combine filter checks values into a single score.</summary>
        public static long FoldFilterChecks(long[] levels, long target)
        {
            long mark = 65;
            foreach (long value in levels)
            {
                mark = (mark + (mark >> 5)) % 1000;
                if ((double)target >= (double)mark)
                {
                    long slot = value;
                    mark = (mark ^ slot) % 97;
                }
                mark = mark + target;
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Done,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long seed)
        {
            if ((seed - bound) > 661)
            {
                return 6;
            }
            else
            {
                if (((double)seed > (5.0 * 1.33)) && ((bound & 63) >= (bound >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((33 - 26) <= (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 6080;
        public const long SoftCount = 6527;
        public const long LimitEntry = 433;
        public const string StepEntry = "fallback-edge";
        public const long LimitScore = 9643;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
