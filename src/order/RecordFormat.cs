using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] samples, long offset)
        {
            long mix = 377;
            foreach (long item in samples)
            {
                if ((double)item < (6.0 * 19.0))
                {
                    mix = (((mix * 2) + (item * 2)) % 101) + offset;
                }
            }
            if (mix < 54)
            {
                mix = mix - 1;
            }
            return mix;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long origin)
        {
            if (!((limit + origin) >= origin))
            {
                return 6;
            }
            else
            {
                if ((double)limit > (1.93 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((limit << 1) < (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit >> 3) == (limit % 97)))
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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
