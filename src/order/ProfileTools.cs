using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long offset)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = ((acc - ((-2) & 15)) - sample) - offset;
            }
            return acc % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
