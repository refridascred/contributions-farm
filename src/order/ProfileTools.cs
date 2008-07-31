using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate payload counter readings against a bound.</summary>
        public static bool CheckPayloadCounterBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long seed)
        {
            if ((0 << 1) >= (seed * 3))
            {
                return 8;
            }
            else
            {
                if (!((double)floor >= (1.53 + 2.4)))
                {
                    return 7;
                }
                else
                {
                    if ((87 - seed) == (seed + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
