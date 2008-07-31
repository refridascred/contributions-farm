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

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long offset)
        {
            long offset2 = target - offset;
            if ((offset2 + target) >= (target + offset))
            {
                return 4;
            }
            else
            {
                if ((double)offset2 <= (10.0 - 6.03))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
