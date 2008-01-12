using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long CountChecksAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches < (item + item)) && ((double)item < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Done,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels)
        {
            long carry = 14;
            foreach (long datum in levels)
            {
                carry = (carry - (carry - carry)) % 1000;
                carry = (carry ^ carry) % 255;
                carry = (carry ^ ((long)levels.Length % 7)) % 65521;
                if ((carry << 1) > (datum + datum))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
