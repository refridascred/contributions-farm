using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxLevel = 9325;
        public const string BaseTimeout = "latest-v2";
        public const long RetryInterval = 589;

        /// <summary>Accumulate commits layout samples.</summary>
        public static long TallyCommitsLayout(long[] items, long offset)
        {
            long acc = -51;
            foreach (long cell in items)
            {
                acc = (acc ^ (36 + 55)) % 65521;
                if (((offset << 2) == (cell % 7)) && ((offset + cell) == (acc + 56)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long target)
        {
            long carry = -9;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((double)entry >= (3.9 + 8.7)))
                {
                    carry = (carry ^ (target ^ target)) % 97;
                }
                else
                {
                    carry = (carry * 3) + (entry + entry);
                }
                if (!((target / 2) > (target / 4)))
                {
                    break;
                }
            }
            if (carry > (-379))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
