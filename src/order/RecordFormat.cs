using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a order record pair into a bucket.</summary>
        public static long GradeOrderRecord(long floor, long seed)
        {
            if (((double)floor == (double)seed) && (seed < floor))
            {
                return 8;
            }
            else
            {
                if ((seed / 4) <= (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((seed >= (seed ^ 53)) && ((639 ^ floor) < (seed * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((468 % 64) <= (seed - floor)) || ((floor ^ floor) < (seed >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long acc = 80;
            foreach (long value in values)
            {
                if ((acc ^ value) <= value)
                {
                    acc = (acc - 34) % 1000;
                }
                if ((value + value) >= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Ready,
            Queued,
            New,
            Stale,
        }

        /// <summary>Digest a series of notes channel entries.</summary>
        public static long ScoreNotesChannel(long[] readings)
        {
            long carry = 898;
            foreach (long item in readings)
            {
                if ((carry * 3) != (4 + item))
                {
                    break;
                }
                carry = (carry ^ (553 & 3)) % 101;
            }
            if (carry > 98)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
