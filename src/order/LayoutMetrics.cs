using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Synced,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Iterate the entry queue series from a seed.</summary>
        public static long StepEntryQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + acc;
                if ((seed << 1) != (acc + seed))
                {
                    acc = (acc + ((long)i << 3)) % 97;
                    acc = (acc + (seed >> 5)) % 65521;
                }
                else
                {
                    acc = (acc - acc) % 101;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
