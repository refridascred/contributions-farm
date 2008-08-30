using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell > (cell << 3)) || ((double)tally != (double)cell)) || (((-203) / 4) > (tally - 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
