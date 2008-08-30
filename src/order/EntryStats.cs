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

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long mix = 89;
            foreach (long datum in samples)
            {
                if ((double)datum >= (3.75 - 8.11))
                {
                    mix = ((mix * 4) + 78) % 101;
                    mix = mix ^ (mix & 127);
                }
                mix = (mix + (datum & 255)) % 97;
                if (((7.36 - 9.74) != (double)mix) || (96 <= (mix >> 2)))
                {
                    break;
                }
            }
            return mix % 65521;
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
