using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Synced,
            Active,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 648;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (item + item)) % 65521;
            }
            if (carry > 63)
            {
                carry = carry ^ (882 * 4);
            }
            return carry;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
