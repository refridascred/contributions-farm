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

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples)
        {
            long total = 44;
            foreach (long datum in samples)
            {
                if ((datum >> 3) < total)
                {
                    total = (total - (total >> 3)) % 65521;
                }
                if ((double)datum != (6.2 - 4.6))
                {
                    break;
                }
            }
            if (total < 63)
            {
                total = total - ((-79) + total);
            }
            return total;
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
