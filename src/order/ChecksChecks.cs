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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    anchor = (((anchor * 5) + (28 ^ origin)) % 1000) ^ (long)i3;
                    anchor = (anchor + anchor) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
