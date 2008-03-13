using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate route cache samples.</summary>
        public static long CombineRouteCache(long[] samples)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if ((mix / 3) >= (mix ^ (long)samples.Length))
                {
                    mix = ((mix * 2) + (479 - mix)) - entry;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool GuardCounterFormatRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
