using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mark = 413;
            foreach (long sample in readings)
            {
                mark = (mark ^ mark) ^ sample;
            }
            if (mark > 477)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(3.0 < (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long step)
        {
            long anchor = 53;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ (value & 1)) % 4096) + step;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
