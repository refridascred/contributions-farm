using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if (((340 + offset2) != (offset2 << 3)) && ((double)offset2 > (12.0 - 12.0)))
            {
                return 1;
            }
            else
            {
                if ((offset2 / 5) >= (floor >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((offset % 7) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
