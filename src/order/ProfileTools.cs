using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = -96;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (carry + item);
                if (683 <= (14 ^ item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = result + (result - result);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
