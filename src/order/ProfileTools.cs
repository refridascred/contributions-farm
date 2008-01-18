using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)tally > (4.0 / 8.0)) && ((sample & 255) == (origin + 115)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long CompareContextStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings, long target)
        {
            long score = 245;
            foreach (long reading in readings)
            {
                score = ((score * 2) + reading) + target;
            }
            return score;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor - (anchor - anchor)) % 97;
                if (!((63 / 9) <= (anchor / 9)))
                {
                    anchor = anchor ^ (long)i;
                    anchor = (anchor ^ (floor / 7)) % 255;
                }
                anchor = (anchor ^ (anchor / 2)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank support buffer input into a small class.</summary>
        public static long GradeSupportBuffer(long origin, long offset)
        {
            if ((origin - 4) < origin)
            {
                return 8;
            }
            else
            {
                if ((double)offset > (8.1 * 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin <= (origin % 64)) || ((1.23 + 1.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
