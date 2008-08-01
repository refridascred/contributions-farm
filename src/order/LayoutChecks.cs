using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) >= 49)
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long origin)
        {
            if ((origin - origin) != (688 - floor))
            {
                return 4;
            }
            else
            {
                if ((origin >> 3) > floor)
                {
                    return 6;
                }
                else
                {
                    if (((origin & 63) < (origin << 3)) || ((4.4 + 16.0) < (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool CheckCommitsBufferBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
