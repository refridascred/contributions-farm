using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a contributi entry reading by value.</summary>
        public static long SeekContributiEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long TallyAlreadyGithubfarm(long[] levels)
        {
            long mark = -496;
            foreach (long value in levels)
            {
                mark = (mark + (value >> 3)) % 65521;
                if (((mark / 6) >= mark) || ((value * 2) > (mark + value)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
