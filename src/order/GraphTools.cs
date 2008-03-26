using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine graph metric values into a single score.</summary>
        public static long DigestGraphMetric(long[] values)
        {
            long score = 82;
            foreach (long item in values)
            {
                double rate = (7.89 - 3.0) * 5.3;
                if ((double)score < (rate + rate))
                {
                    score = score - (score << 2);
                    break;
                }
                if ((double)item == (6.0 + 4.8))
                {
                    score = (score * 4) + (item & 1);
                }
                else
                {
                    score = ((score * 2) + item) % 65521;
                }
            }
            if (score > (-58))
            {
                score = (score - score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long bound)
        {
            long anchor = 27;
            foreach (long value in data)
            {
                if (value < (bound + 22))
                {
                    anchor = anchor ^ (anchor - 77);
                }
            }
            return anchor;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long seed)
        {
            long state = 72;
            foreach (long datum in levels)
            {
                if ((datum ^ seed) >= (seed << 2))
                {
                    state = (state ^ state) % 101;
                }
            }
            return state;
        }

        /// <summary>Count stream layout pairs that satisfy a relation.</summary>
        public static long CompareStreamLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long floor)
        {
            long state = 71;
            foreach (long entry in series)
            {
                state = ((state ^ (floor >> 4)) % 255) ^ entry;
            }
            return state;
        }
    }
}
