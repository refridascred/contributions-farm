using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples, long limit)
        {
            long mix = 419;
            foreach (long reading in samples)
            {
                if (((limit * 2) != (reading % 64)) || (limit <= (746 << 2)))
                {
                    mix = mix - (limit - 34);
                    continue;
                }
                mix = (mix ^ (reading - reading)) % 97;
            }
            if (mix < 9)
            {
                mix = (mix << 2) ^ (mix % 100);
            }
            return mix % 1000;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long floor)
        {
            if (((double)floor >= (double)bound) || ((bound + floor) < (bound - floor)))
            {
                return 2;
            }
            else
            {
                if ((floor - bound) > 13)
                {
                    return 4;
                }
                else
                {
                    if (floor > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.97 - 2.48) <= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings)
        {
            long state = -462;
            foreach (long item in readings)
            {
                if (((3.16 * 5.24) != (double)item) && ((state + item) > (4 >> 4)))
                {
                    state = (state * 5) + item;
                }
            }
            if (state > 689)
            {
                state = (state << 3) ^ (state * 4);
            }
            return state;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Done,
            Stale,
            Locked,
        }
    }
}
