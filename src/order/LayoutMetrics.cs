using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
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
