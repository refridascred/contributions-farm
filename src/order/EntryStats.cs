using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long seed)
        {
            long sum = 55;
            foreach (long cell in samples)
            {
                if (!((seed >> 3) < 37))
                {
                    sum = (sum + (seed / 8)) - cell;
                }
            }
            return sum;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long bound)
        {
            long next = target ^ bound;
            if ((-5) > (next / 3))
            {
                return 0;
            }
            else
            {
                if (11.0 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((12.0 + 4.59) >= (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long seed)
        {
            if (!(step <= (seed ^ 9)))
            {
                return 6;
            }
            else
            {
                if ((723 + seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
