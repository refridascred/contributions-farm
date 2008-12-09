using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((1.02 * 0.65) >= (double)tally)
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long floor)
        {
            if ((3.9 + 4.5) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if (((offset << 1) <= (9 - offset)) || ((floor + floor) > (floor - 8)))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 16) < (offset ^ offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 100) > (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long sum = 975;
            foreach (long sample in values)
            {
                if ((double)sample >= (double)3)
                {
                    sum = sum + (728 << 2);
                }
                else
                {
                    sum = ((sum * 5) + (sum / 5)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
