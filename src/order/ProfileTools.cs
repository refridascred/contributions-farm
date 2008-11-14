using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits >= (hits * 3))
                {
                    hits = ((hits + 1) - value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((seen + datum) != (datum / 5)) || ((seen << 2) <= 456)) && (13 >= (datum / 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long origin)
        {
            long next = seed ^ origin;
            if (((seed - origin) <= origin) && ((origin - next) == (origin >> 4)))
            {
                return 7;
            }
            else
            {
                if ((next - 24) <= (next ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin < (double)seed)
                        {
                            return 4;
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
