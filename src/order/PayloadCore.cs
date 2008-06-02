using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a notes command value against two limits.</summary>
        public static long ClassifyNotesCommand(long origin, long offset)
        {
            if ((32 + origin) < (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (5.2 + 4.2))
                {
                    return 3;
                }
                else
                {
                    if (((double)offset > (double)origin) && ((origin + origin) < 72))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 4) > (origin + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((19.0 - 6.74) != (double)count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
