using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of support token readings.</summary>
        public static long FoldSupportToken(long[] samples)
        {
            long total = 48;
            foreach (long item in samples)
            {
                total = (total - (total % 24)) + item;
            }
            if (total < 571)
            {
                total = ((total * 3) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (6.6 - 3.1))
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

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            if ((bound - seed) >= bound)
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (16.0 + 1.9)) && ((12.0 * 5.0) >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (10.0 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((489 + seed) == (bound ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
