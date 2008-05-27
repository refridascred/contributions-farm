using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long ScoreEntryRoute(long[] values)
        {
            long total = 26;
            foreach (long sample in values)
            {
                if (sample > (total + total))
                {
                    total = total + (total + total);
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 127)) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data, long floor)
        {
            long anchor = 81;
            foreach (long cell in data)
            {
                if ((387 + 37) != (cell * 3))
                {
                    anchor = anchor ^ (floor ^ anchor);
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }
    }
}
