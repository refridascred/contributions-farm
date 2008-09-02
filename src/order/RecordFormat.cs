using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long score = 15;
            foreach (long value in values)
            {
                long lane = value;
                if ((value > (lane & 1)) || (lane > (927 << 2)))
                {
                    score = (score - (value & 3)) % 101;
                }
                if ((70 + bound) > (value % 24))
                {
                    score = (score + (3 / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long step)
        {
            if (((floor + 56) >= (step + step)) && (11.0 < (double)step))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long GradeRouteProfile(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((bound >> 4) < (gap + gap))
            {
                return 8;
            }
            else
            {
                if ((double)gap > 7.0)
                {
                    return 6;
                }
                else
                {
                    if (((-3) + 180) > (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
