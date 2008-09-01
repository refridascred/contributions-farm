using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8101;
        public const double IdleScore = 8.29;
        public const long SoftContext = 638;
        public const long LimitSpan = 182;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((reading % 24) < reading) && ((count << 3) < count)) || (((count / 4) <= 24) || ((70 >> 1) >= (3 + reading))))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
