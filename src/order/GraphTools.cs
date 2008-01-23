using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Active,
            Pending,
            New,
            Draft,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long step)
        {
            if ((step + seed) != (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((0 + 269) < (seed + (-811)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) <= (seed % 24))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((551 << 1) <= (step ^ 972)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((carry * 4) >= (carry + (long)i))
                {
                    carry = carry ^ (long)i;
                    carry = (carry + (carry ^ step)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many githubfarm order samples are out of range.</summary>
        public static long TallyGithubfarmOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((924 + cell) > (count % 10))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((-195) ^ count) == (entry + 619)) || ((entry + count) > (entry * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
