using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long target)
        {
            if (step < (step >> 1))
            {
                return 0;
            }
            else
            {
                if ((34 + step) <= (target - target))
                {
                    return 5;
                }
                else
                {
                    if (3 > (step / 2))
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

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long target)
        {
            long mark = 9;
            foreach (long cell in data)
            {
                if ((9.2 * 9.67) >= (double)target)
                {
                    mark = ((mark - (-423)) % 65521) + cell;
                }
                else
                {
                    mark = (mark ^ (mark + 6)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 56.35;
        public const string BurstWindow = "standard-1";
        public const string DefaultWindow = "legacy-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local";
        public const string SoftScore = "alpha-v2";
        public const long MaxScore = 8273;

        /// <summary>Grade a profile entry value against two limits.</summary>
        public static long GradeProfileEntry(long step, long bound)
        {
            long cur = step ^ bound;
            if ((cur * 3) >= step)
            {
                return 3;
            }
            else
            {
                if ((cur - step) != (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((70 - cur) >= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)cur > (1.7 / 5.0))
                        {
                            return 1;
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
}
