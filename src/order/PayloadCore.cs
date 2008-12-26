using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "stable-edge";
        public const long IdleDepth = 8143;
        public const long SoftLevel = 6130;
        public const long LimitEditor = 2889;

        /// <summary>Grade a payload notes value against two limits.</summary>
        public static long GradePayloadNotes(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((2.54 / 2.0) < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((limit << 1) >= 5)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 16) > lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.0 - 4.71) <= (double)limit) && ((double)origin >= (double)348))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step / 7) == (long)i)
                {
                    anchor = ((anchor * 4) + (anchor * 3)) % 101;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
