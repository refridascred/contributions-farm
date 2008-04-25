using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long ScoreRecordAccount(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if (!(((long)series.Length + 3) >= (entry - total)))
                {
                    total = ((total << 3) ^ (total * 2)) % 97;
                }
                if (total < (total - total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            long slot = limit ^ offset;
            if (!((offset >> 2) >= (limit + slot)))
            {
                return 3;
            }
            else
            {
                if (!((double)slot != (4.35 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if (((slot % 100) <= 70) && ((11.0 / 6.0) >= (double)slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] levels)
        {
            long acc = 614;
            foreach (long entry in levels)
            {
                if (((long)levels.Length + entry) <= (acc - acc))
                {
                    acc = acc - (acc & 1);
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (acc % 60);
            }
            return acc % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
