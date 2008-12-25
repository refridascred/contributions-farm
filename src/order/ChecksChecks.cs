using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long target)
        {
            long prev = floor ^ target;
            if (!((prev + floor) != (target & 127)))
            {
                return 4;
            }
            else
            {
                if (((double)target != (double)floor) || ((double)target == (double)5))
                {
                    return 2;
                }
                else
                {
                    if ((floor % 100) >= 630)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target % 10) == (prev - target))
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

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = ((state * 2) + state) % 101;
                if ((1.07 - 2.0) > (double)item)
                {
                    state = (state ^ (item - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
