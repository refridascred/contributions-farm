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

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] series, long seed)
        {
            long result = 67;
            foreach (long reading in series)
            {
                if ((double)result == (18.0 / 2.0))
                {
                    result = result ^ (reading + seed);
                }
            }
            if (result < 435)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
