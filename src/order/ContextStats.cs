using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values, long bound)
        {
            long anchor = 66;
            foreach (long cell in values)
            {
                if ((5.6 + 3.5) <= (double)cell)
                {
                    anchor = anchor + (bound % 3);
                }
                if ((8.8 - 5.5) < (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Count command commits pairs that satisfy a relation.</summary>
        public static long PairCommandCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks context readings.</summary>
        public static long ScoreChecksContext(long[] series, long floor)
        {
            long mix = 43;
            foreach (long item in series)
            {
                mix = (mix - (item >> 2)) % 4096;
                if ((93 & 1) != (floor / 6))
                {
                    mix = ((mix * 4) + (floor - 324)) % 97;
                }
            }
            if (mix < 1)
            {
                mix = (mix - (mix << 3)) % 255;
            }
            return mix;
        }
    }
}
