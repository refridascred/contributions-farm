using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1608;
        public const long DefaultWidth = 7977;
        public const double MinLevel = 21.38;
        public const string BatchChannel = "alpha-1";
        public const long MinChannel = 6195;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long result = 23;
            foreach (long sample in levels)
            {
                result = ((result * 4) + result) + sample;
            }
            if (result < 2)
            {
                result = (result * 4) + ((long)levels.Length / 4);
            }
            return result;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long step)
        {
            long bound = floor ^ step;
            if ((floor >= 62) || (3.25 < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((1 >= (step + bound)) && ((step - floor) < 74))
                {
                    return 4;
                }
                else
                {
                    if ((floor + bound) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 63) < (item >> 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
