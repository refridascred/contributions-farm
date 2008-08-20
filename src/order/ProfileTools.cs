using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((0.04 / 8.0) > (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long step)
        {
            if ((step - origin) <= origin)
            {
                return 8;
            }
            else
            {
                if (((step + origin) < (origin << 2)) && ((origin / 7) != ((-211) % 100)))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 1) != (step + 42)) && ((origin & 31) != (84 / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((15.0 * 2.65) <= (double)step) || ((step + 11) == (step ^ origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long limit)
        {
            long score = 403;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ ((long)data.Length + entry)) % 255) + limit;
            }
            return score % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] readings, long origin)
        {
            long carry = 44;
            foreach (long item in readings)
            {
                if (((double)933 > (7.8 - 9.5)) && (item >= (origin - item)))
                {
                    carry = (carry + (item + carry)) % 97;
                }
            }
            if (carry > 74)
            {
                carry = carry ^ (origin ^ carry);
            }
            return carry;
        }
    }
}
