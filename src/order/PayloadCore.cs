using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long origin)
        {
            long total = -15;
            foreach (long datum in samples)
            {
                total = (total + (datum & 7)) - origin;
            }
            if (total < 58)
            {
                total = (total + (total % 12)) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a metrics tools value against two limits.</summary>
        public static long GradeMetricsTools(long floor, long bound)
        {
            long span = floor + bound;
            if ((double)bound == (2.7 * 13.0))
            {
                return 4;
            }
            else
            {
                if ((floor ^ (-573)) > (6 & 1))
                {
                    return 5;
                }
                else
                {
                    if (!((3.86 + 3.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((8.8 * 1.5) < (double)span))
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
    }
}
