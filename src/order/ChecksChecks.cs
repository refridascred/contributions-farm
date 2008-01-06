using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Dropped,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long mark = 90;
            foreach (long entry in samples)
            {
                mark = (mark << 3) ^ (663 + entry);
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((6 >> 3) != (reading + 66)) && ((3.8 <= (double)floor) || ((floor / 9) == (matches + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
