using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) <= (708 % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            long prev = origin + seed;
            if ((56 << 2) <= ((-887) + prev))
            {
                return 2;
            }
            else
            {
                if ((325 - (-56)) >= (7 ^ prev))
                {
                    return 6;
                }
                else
                {
                    if (prev <= (842 & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= 5.6)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
