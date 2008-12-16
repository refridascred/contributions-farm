using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = ((carry + (carry + entry)) % 1000) - floor;
                carry = carry + (entry - entry);
            }
            return carry % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "open-edge";
        public const string IdleWidth = "latest-1";
        public const long BatchDepth = 1136;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((3.28 + 9.1) > (double)origin2)
            {
                return 0;
            }
            else
            {
                if ((bound ^ bound) >= (origin * 3))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 >> 5) < 828)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 7) > origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
