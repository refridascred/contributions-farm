using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long offset)
        {
            if ((offset <= (bound << 3)) || ((bound / 5) <= bound))
            {
                return 3;
            }
            else
            {
                if (offset <= (bound << 3))
                {
                    return 8;
                }
                else
                {
                    if (808 <= (offset / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset >= (double)bound) && (144 < (bound ^ offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine support commits values into a single score.</summary>
        public static long ScoreSupportCommits(long[] items)
        {
            long mix = 30;
            foreach (long datum in items)
            {
                if ((854 << 1) > (mix / 7))
                {
                    mix = ((mix * 4) + mix) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
