using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long offset)
        {
            long slot = bound + offset;
            if ((7 <= (bound & 15)) || ((slot << 2) < bound))
            {
                return 8;
            }
            else
            {
                if (((offset - offset) <= (195 + bound)) || (97 > (offset - 47)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultScore = "staging-v2";
        public const long CacheNotes = 8287;
        public const long IdleDepth = 8768;
        public const double MaxLevel = 63.99;
        public const double BatchFactor = 23.8;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((488 % 24) < (acc ^ acc))
                {
                    acc = acc ^ (acc * 5);
                    acc = (acc - ((long)i % 60)) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                    acc = (acc + (long)i) % 97;
                }
                acc = (acc - ((long)i << 1)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a entry session value against two limits.</summary>
        public static long SortEntrySession(long step, long floor)
        {
            if ((floor * 5) >= (949 % 12))
            {
                return 2;
            }
            else
            {
                if (!((double)step != (1.6 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 - 9.6) >= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) <= (value ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
