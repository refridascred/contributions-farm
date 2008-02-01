using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if ((delta + offset2) == (2 / 4))
            {
                return 7;
            }
            else
            {
                if ((delta + 867) >= (offset2 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ offset) < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph tools readings against a bound.</summary>
        public static bool GuardGraphToolsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)origin <= (1.0 + 16.0))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
