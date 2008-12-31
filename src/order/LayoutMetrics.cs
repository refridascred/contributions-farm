using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values, long limit)
        {
            long state = 39;
            foreach (long value in values)
            {
                state = ((state + (value >> 3)) % 101) - limit;
                if ((double)value >= 1.44)
                {
                    state = (state + (107 + 218)) % 97;
                }
            }
            return state;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mix = 79;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + mix) <= ((-22) - datum))
                {
                    mix = mix - (datum ^ datum);
                }
                else
                {
                    mix = mix ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!(cell > floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
