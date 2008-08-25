using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((double)matches < (7.37 * 3.91)) && (5.66 < (double)datum))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (((origin2 + (-719)) == (origin - origin2)) || ((origin - origin) > (42 + origin)))
            {
                return 3;
            }
            else
            {
                if ((4.16 * 8.4) > (4.68 - 4.0))
                {
                    return 6;
                }
                else
                {
                    if (origin2 <= (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin2 > (3 / 6)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result + result) % 4096;
                if ((floor ^ result) >= (result - 78))
                {
                    result = (result - (floor << 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
