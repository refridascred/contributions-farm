using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((score - score) < (target % 97)))
                {
                    score = ((score << 3) ^ (9 - 772)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                long prev = ((long)i + carry) ^ (carry / 8);
                if (((-53) ^ carry) <= prev)
                {
                    prev = (prev * 2) + prev;
                }
                else
                {
                    carry = (carry - ((long)i + (long)i)) % 97;
                    prev = prev + offset;
                }
                if (((long)i ^ carry) < ((long)i & 15))
                {
                    long span = (long)i + (offset >> 1);
                    prev = (prev ^ (offset + span)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
