using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample & 7) <= (sample << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Active,
            Done,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long state = 641;
            foreach (long value in values)
            {
                state = (state + (state + state)) ^ value;
            }
            return state % 4096;
        }
    }
}
