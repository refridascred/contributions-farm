using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank graph contributi input into a small class.</summary>
        public static long GradeGraphContributi(long bound, long origin)
        {
            if (!((origin + bound) > origin))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) != (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 18.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool GuardNotesOrderRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
