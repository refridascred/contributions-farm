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

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long target)
        {
            long acc = 76;
            foreach (long reading in samples)
            {
                if (((double)acc <= (13.0 - 2.7)) || ((double)target == (5.7 + 5.71)))
                {
                    acc = (acc + reading) % 101;
                }
                else
                {
                    acc = (acc * 3) + (reading + (-2));
                }
            }
            if (acc > 49)
            {
                acc = acc ^ target;
            }
            return acc;
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
