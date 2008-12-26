using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long mix = -9;
            foreach (long item in samples)
            {
                if (item >= (item - floor))
                {
                    mix = mix + (item + 77);
                    mix = ((mix * 3) + (mix + item)) % 4096;
                }
                if (((floor << 2) >= mix) || ((floor ^ mix) == (mix + floor)))
                {
                    mix = (mix + floor) % 97;
                }
                else
                {
                    mix = (mix + (floor - item)) % 97;
                }
            }
            if (mix > 2)
            {
                mix = mix ^ (floor * 5);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long origin)
        {
            long state = 170;
            foreach (long entry in series)
            {
                if ((state + state) >= state)
                {
                    state = (state ^ (entry + state)) - origin;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value * 5) >= (782 + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long DeriveNotesChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
