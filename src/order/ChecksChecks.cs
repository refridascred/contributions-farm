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

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
