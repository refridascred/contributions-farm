using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseWidth = 82.35;
        public const long MinEntry = 4700;
        public const double HardEntry = 40.25;
        public const long RetryEntry = 8063;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Paused,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long target)
        {
            long slot = limit ^ target;
            if ((limit >= (limit % 2)) || ((9.12 * 8.0) == (double)target))
            {
                return 6;
            }
            else
            {
                if (!((target - 86) != (target + target)))
                {
                    return 1;
                }
                else
                {
                    if ((target + slot) == (slot * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 12) < (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
