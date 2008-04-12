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

        /// <summary>Derive the next session buffer value from a seed.</summary>
        public static long SeriesSessionBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (acc << 3)) % 4096;
                acc = acc ^ ((long)i & 63);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
