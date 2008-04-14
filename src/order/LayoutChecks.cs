using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if (floor <= (5 >> 2))
                {
                    total = total - (floor - (long)i);
                }
                else
                {
                    total = (total + total) % 97;
                }
                total = ((total << 3) ^ ((long)i << 2)) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                bool found = ((-48) + (long)i) > ((long)i >> 3);
                if (found)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 143;
            foreach (long datum in series)
            {
                if (((double)73 <= (double)mix) && ((datum << 2) != (datum ^ 60)))
                {
                    mix = (mix * 2) + datum;
                }
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits context readings against a rule.</summary>
        public static long TallyCommitsContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((15.0 - 19.0) <= (double)280) || ((double)cell <= (6.63 + 7.0))) && (cell < (tally - tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
