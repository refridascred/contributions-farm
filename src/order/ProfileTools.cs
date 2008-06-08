using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long anchor = 877;
            foreach (long entry in readings)
            {
                if (!((entry - (long)readings.Length) > (anchor * 4)))
                {
                    anchor = anchor - (entry + anchor);
                }
                anchor = (anchor * 4) + entry;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
