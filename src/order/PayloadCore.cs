using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long state = 4;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (reading >> 3)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)6 > (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
