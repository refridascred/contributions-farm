using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            New,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count batch already pairs that satisfy a relation.</summary>
        public static long MatchBatchAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
