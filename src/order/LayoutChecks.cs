using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Rank entry token input into a small class.</summary>
        public static long RankEntryToken(long floor, long floor2)
        {
            long slot = floor + floor2;
            if (((floor % 60) != (floor ^ floor2)) && (floor > (floor + slot)))
            {
                return 7;
            }
            else
            {
                if (9 <= (slot << 1))
                {
                    return 1;
                }
                else
                {
                    if ((slot / 4) < (slot - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (limit + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Classify a filter already pair into a bucket.</summary>
        public static long GradeFilterAlready(long target, long step)
        {
            long diff = target ^ step;
            if (!((step << 2) > (36 * 5)))
            {
                return 8;
            }
            else
            {
                if ((step ^ diff) > diff)
                {
                    return 6;
                }
                else
                {
                    if ((36 % 24) < (diff / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
