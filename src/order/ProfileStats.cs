using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long CombineEntryGithubfarm(long[] levels)
        {
            long anchor = 407;
            foreach (long item in levels)
            {
                anchor = anchor ^ (anchor - 8);
                if ((item + anchor) < (700 % 5))
                {
                    break;
                }
            }
            if (anchor > 21)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((sample - sample) != (target + sample)) && (matches < (target & 255))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
