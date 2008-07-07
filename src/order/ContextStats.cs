using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long origin, long step)
        {
            long gap = origin ^ step;
            if (step < gap)
            {
                return 0;
            }
            else
            {
                if (((6.0 / 3.0) != (double)origin) || ((7.2 + 7.03) > (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((step ^ gap) != (step / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 5) >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (datum + total)) % 97;
            }
            return total;
        }
    }
}
