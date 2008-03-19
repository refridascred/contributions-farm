using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long step2)
        {
            if ((step - step2) <= (step & 7))
            {
                return 3;
            }
            else
            {
                if ((double)step2 >= (7.91 * 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((step2 + step2) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
