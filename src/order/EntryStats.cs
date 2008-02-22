using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Synced,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] values, long target)
        {
            long sum = 9;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum * 3)) % 101;
                sum = (sum ^ target) % 255;
                if (!((double)datum < (7.5 * 5.6)))
                {
                    break;
                }
            }
            if (sum > 73)
            {
                sum = sum - (533 * 4);
            }
            return sum;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample >= (matches + floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
