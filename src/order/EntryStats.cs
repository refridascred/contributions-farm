using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark << 3) ^ (offset - mark);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Roll a format githubfarm counter forward.</summary>
        public static long StepFormatGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                bool ok = (-50) > (seed * 5);
                if (ok && ((carry << 2) <= carry))
                {
                    ok = ok;
                    carry = (carry + (30 + seed)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ 313) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
