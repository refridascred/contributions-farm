using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + count) > (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] values)
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
    }
}
