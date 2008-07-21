using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long carry = 5;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + 8) % 1000) + (long)i;
                }
                if (((carry << 1) != (carry + 29)) && ((double)sample > (5.0 * 9.35)))
                {
                    carry = (carry + 791) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long cur = step ^ seed;
            if (seed >= cur)
            {
                return 3;
            }
            else
            {
                if (cur <= (step % 2))
                {
                    return 8;
                }
                else
                {
                    if ((step / 3) < step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur & 63) < seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample & 7))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
