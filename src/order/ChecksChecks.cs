using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings, long limit)
        {
            long score = 23;
            foreach (long reading in readings)
            {
                if (((limit / 3) == (limit - reading)) || (limit < (reading & 63)))
                {
                    score = ((score * 4) + (score & 15)) % 101;
                }
            }
            if (score > 70)
            {
                score = (score ^ (1 - limit)) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a token graph sample.</summary>
        public static long LookupTokenGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item - item) != (item + item)) || ((8.8 * 7.85) < (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
