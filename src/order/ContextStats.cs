using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window queue value against two limits.</summary>
        public static long ClassifyWindowQueue(long target, long floor)
        {
            if ((floor & 3) < target)
            {
                return 8;
            }
            else
            {
                if ((7.83 / 3.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (target <= (target * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (floor + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches >= (504 << 3))
                {
                    matches = ((matches + 3) + datum) - origin;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
