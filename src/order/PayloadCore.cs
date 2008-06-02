using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Synced,
            Locked,
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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long step, long seed)
        {
            if ((double)seed <= (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)seed != (double)step)
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step <= (8.5 - 7.3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Retry,
            Failed,
            Closed,
        }
    }
}
