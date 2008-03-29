using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
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

        /// <summary>Fold a list of order farm readings.</summary>
        public static long TallyOrderFarm(long[] series, long step)
        {
            long result = 5;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + step) % 65521) - sample;
                    result = result ^ (long)i;
                }
                if (result < (6 * 3))
                {
                    result = (result + (53 / 6)) % 1000;
                }
                else
                {
                    result = ((result * 3) + (result * 5)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
