using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a support counter reading by value.</summary>
        public static long SeekSupportCounterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Queued,
            Done,
            Synced,
            Active,
        }

        /// <summary>Digest a series of already buffer entries.</summary>
        public static long TotalAlreadyBuffer(long[] series)
        {
            long state = 501;
            foreach (long entry in series)
            {
                if (entry <= (152 & 15))
                {
                    state = (state - entry) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
