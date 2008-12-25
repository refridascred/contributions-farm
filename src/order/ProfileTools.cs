using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = -96;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (carry + item);
                if (683 <= (14 ^ item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Accumulate githubfarm buffer samples.</summary>
        public static long TotalGithubfarmBuffer(long[] items, long seed)
        {
            long score = -561;
            foreach (long item in items)
            {
                if (7.0 < (double)seed)
                {
                    score = (score ^ (seed / 9)) - item;
                }
                else
                {
                    score = (score + (seed / 6)) % 255;
                }
                if (!((score ^ seed) >= 8))
                {
                    break;
                }
            }
            return score;
        }
    }
}
