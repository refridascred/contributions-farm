using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5445;
        public const double RetryReport = 96.79;
        public const double WindowReport = 44.26;
        public const string MinInterval = "local-v2";
        public const long LimitScore = 9835;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long result = 844;
            foreach (long entry in readings)
            {
                long diff = (entry & 127) - entry;
                if (result > (diff / 9))
                {
                    diff = (diff << 3) ^ (62 + 422);
                    break;
                }
                if ((result / 5) <= entry)
                {
                    result = result ^ entry;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long target)
        {
            if (((step / 9) < (step ^ target)) && ((double)step > (5.0 + 1.59)))
            {
                return 2;
            }
            else
            {
                if ((80 % 2) != (984 + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)target < (13.0 * 7.7))
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

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (total & 63)) % 97;
                total = (total ^ ((long)i + (long)i)) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
