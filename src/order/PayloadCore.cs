using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((14.0 + 3.69) < (double)origin)
            {
                return 7;
            }
            else
            {
                if (((seed * 4) == (origin - origin)) && ((3.28 + 0.6) >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (7 <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((double)entry < (2.0 * 5.6)) || (1.5 > (double)seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step / 7) == (long)i)
                {
                    anchor = ((anchor * 4) + (anchor * 3)) % 101;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
