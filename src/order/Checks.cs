using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                long matches = item;
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry ^ (matches ^ seed)) - (long)i;
                    matches = (matches + (item ^ item)) % 97;
                }
                if ((seed + carry) >= seed)
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = ((carry * 4) + (carry + (-269))) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor + floor2) <= (10 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor2 + offset) == (floor2 + 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (0.9 + 8.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor2 > (8.4 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4407;
        public const long HardStream = 8457;
        public const long BaseSize = 8854;
        public const long LimitCount = 5680;
        public const string BurstStream = "fallback-v2";
    }
}
