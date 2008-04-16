using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            New,
            Dropped,
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

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long CombineBatchStats(long[] levels, long step)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                total = (total << 3) ^ (step - total);
                if ((cell - 24) == (total & 63))
                {
                    break;
                }
            }
            return total % 97;
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
