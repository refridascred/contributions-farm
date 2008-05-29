using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long MeasureNotesProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((3.8 - 2.5) > (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally ^ tally) <= (tally + 856))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (result + (long)i)) % 101;
                result = result + ((long)i - 6);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
