using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) > (sample - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items)
        {
            long state = 854;
            foreach (long entry in items)
            {
                state = state ^ (entry >> 2);
                state = (state - (entry & 1)) % 255;
                if ((state + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 291;
            foreach (long cell in samples)
            {
                if ((5.0 <= (double)cell) || (((long)samples.Length * 2) < (cell >> 5)))
                {
                    result = (result ^ (result + cell)) % 97;
                }
                if (result <= (result ^ result))
                {
                    result = (result + (cell + result)) % 255;
                }
                else
                {
                    result = result + ((long)samples.Length + 5);
                }
            }
            return result;
        }
    }
}
