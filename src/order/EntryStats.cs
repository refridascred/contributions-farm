using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if ((double)offset2 <= 11.0)
            {
                return 6;
            }
            else
            {
                if ((3.0 - 5.6) > (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset2) < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits & 1) > hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Derive the next counter notes value from a seed.</summary>
        public static long RollCounterNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = result - 7;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
