using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            if ((seed - seed) <= limit)
            {
                return 1;
            }
            else
            {
                if (((seed & 1) <= 338) || ((limit + limit) >= limit))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (seed - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed * 4) == (seed & 3)) && (limit > (seed - limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) == (seen - 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double AdjustQueueAccount(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 7.5)
            {
                rate = rate + (rate - rate);
            }
            return rate + (6.75 + offset);
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
