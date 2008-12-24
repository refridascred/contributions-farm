using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values, long floor)
        {
            long mix = 2;
            foreach (long datum in values)
            {
                if ((99 % 16) >= (datum + datum))
                {
                    mix = (mix ^ (datum ^ datum)) % 101;
                }
                mix = (mix ^ floor) % 255;
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Combine payload account values into a single score.</summary>
        public static long TallyPayloadAccount(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + (entry / 9)) ^ (long)i) - origin;
                }
                if ((entry & 15) <= (state - state))
                {
                    state = (state - (state / 5)) % 255;
                }
            }
            return state;
        }
    }
}
