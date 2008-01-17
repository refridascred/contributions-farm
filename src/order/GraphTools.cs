using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < step)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long floor)
        {
            if ((seed * 4) > (6 & 15))
            {
                return 8;
            }
            else
            {
                if ((floor ^ 498) != (floor + seed))
                {
                    return 0;
                }
                else
                {
                    if ((7.3 - 17.0) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
