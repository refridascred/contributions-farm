using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long offset)
        {
            long anchor = 43;
            foreach (long value in items)
            {
                if ((8 >> 5) < anchor)
                {
                    anchor = ((anchor << 3) ^ 374) ^ value;
                }
            }
            if (anchor < 19)
            {
                anchor = (anchor ^ (offset * 5)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ 730) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
