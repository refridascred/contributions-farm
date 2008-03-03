using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route stream samples are out of range.</summary>
        public static long AuditRouteStreamOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches >> 2) <= (matches % 2))
                {
                    matches = ((matches + 2) - sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ ((long)i % 16);
                mix = (mix << 3) ^ ((long)i << 2);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
