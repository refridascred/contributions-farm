using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long acc = 56;
            foreach (long item in series)
            {
                if ((item + acc) >= acc)
                {
                    acc = acc - (72 + item);
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
                if (!((item ^ item) > item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = ((total - total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "staging";
        public const double DefaultTools = 92.87;
        public const long WindowTools = 3830;
    }
}
