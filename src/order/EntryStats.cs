using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long target)
        {
            long mix = 56;
            foreach (long entry in levels)
            {
                mix = (((mix * 5) + (entry * 3)) % 97) - target;
            }
            return mix;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Grade a profile payload value against two limits.</summary>
        public static long ClassifyProfilePayload(long limit, long floor)
        {
            long prev = limit - floor;
            if (prev > (floor - 517))
            {
                return 5;
            }
            else
            {
                if ((prev % 3) < (69 * 2))
                {
                    return 1;
                }
                else
                {
                    if (((floor >> 3) >= limit) || (3 >= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)prev < (9.45 - 9.2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long TallyEditorGraph(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((result + reading) >= (661 + result))
                {
                    result = result - (reading - result);
                }
            }
            if (result > 94)
            {
                result = ((result << 3) ^ (result ^ result)) % 1000;
            }
            return result % 4096;
        }
    }
}
