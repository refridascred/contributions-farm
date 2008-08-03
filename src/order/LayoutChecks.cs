using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((step + (long)samples.Length) == (value % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleTimeout = 28.14;
        public const long LimitLevel = 8052;
        public const string WindowFilter = "stable-v2";
        public const string MaxSize = "primary-v2";
        public const long IdleScore = 1757;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            long step = origin - limit;
            if (((origin + 7) < origin) && (limit > step))
            {
                return 6;
            }
            else
            {
                if ((origin << 1) > (limit / 9))
                {
                    return 2;
                }
                else
                {
                    if (((-58) <= (origin + step)) && ((3.11 + 1.09) != (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
