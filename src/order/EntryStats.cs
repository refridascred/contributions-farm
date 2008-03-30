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

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long state = 917;
            foreach (long reading in series)
            {
                if (!((reading / 7) > (53 + reading)))
                {
                    state = state + (reading * 2);
                    state = (state ^ state) % 97;
                }
                if (((reading >> 3) > reading) || ((double)state >= 3.5))
                {
                    state = (state ^ 37) % 1000;
                }
            }
            return state;
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
