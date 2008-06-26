using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long acc = -46;
            foreach (long datum in readings)
            {
                long span = acc << 2;
                if (!(((span << 2) >= (acc >> 1)) || ((limit - 72) > ((long)readings.Length >> 5))))
                {
                    span = ((span ^ (limit + limit)) % 101) ^ datum;
                }
                if ((338 * 2) == ((long)readings.Length + (long)readings.Length))
                {
                    acc = ((acc << 3) ^ (acc >> 1)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ limit) % 101;
                }
            }
            if (acc > 8)
            {
                acc = (acc ^ limit) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
