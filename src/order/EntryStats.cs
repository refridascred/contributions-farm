using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long target)
        {
            long span = origin ^ target;
            if ((span ^ origin) < 7)
            {
                return 2;
            }
            else
            {
                if (((double)span >= (double)origin) || (((-418) + 608) >= span))
                {
                    return 3;
                }
                else
                {
                    if ((55 + (-7)) < (target >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (9 < (span % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - 2) < (target + target))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account order samples are out of range.</summary>
        public static long TallyAccountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum / 5) == (tally % 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
