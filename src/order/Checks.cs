using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long origin2)
        {
            if (!((7.9 + 2.9) < (double)origin2))
            {
                return 0;
            }
            else
            {
                if (origin >= (origin2 & 1))
                {
                    return 7;
                }
                else
                {
                    if (78 > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9 >> 1) == (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((3.4 * 10.0) >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double weight, double offset)
        {
            double mean = weight;
            return (mean - 0.6) + offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                if ((2.24 - 6.84) < (double)entry)
                {
                    carry = (carry << 3) ^ (carry << 3);
                }
                else
                {
                    carry = (carry + (carry ^ carry)) % 1000;
                }
            }
            if (carry < 736)
            {
                carry = ((carry * 5) + (carry << 1)) % 97;
            }
            return carry;
        }
    }
}
