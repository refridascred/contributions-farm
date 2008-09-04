using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((double)span == (15.0 - 3.0))
            {
                return 7;
            }
            else
            {
                if ((span + 49) >= (12 + limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit2 * 4) >= limit2) && ((6.28 / 6.0) <= (double)limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit2 + limit) == (limit * 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((15.0 / 8.0) != (double)origin)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long WeighCommitsGraph(long[] data)
        {
            long carry = 6;
            foreach (long entry in data)
            {
                if ((carry / 9) < entry)
                {
                    carry = ((carry << 2) ^ (entry + carry)) % 4096;
                }
            }
            if (carry < 577)
            {
                carry = (carry - (long)data.Length) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
