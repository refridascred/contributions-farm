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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
