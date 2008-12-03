using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a checks window counter forward.</summary>
        public static long DeriveChecksWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((sum - (-5)) >= (floor + floor))
                {
                    sum = ((sum * 3) + (sum - (long)i)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((offset << 1) < offset)
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (double)359)
                {
                    return 4;
                }
                else
                {
                    if (((floor + offset) < (offset & 7)) || ((double)offset > (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
