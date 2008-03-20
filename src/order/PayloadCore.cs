using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)5 < (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step * 5) > step)
                {
                    carry = ((carry << 2) ^ (step << 2)) % 255;
                }
                long tally = step % 7;
                if ((tally + (long)i) != (step - carry))
                {
                    carry = carry ^ carry;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long MeasureToolsGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - value) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long origin)
        {
            if ((5.1 * 3.17) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (origin >= (origin - step))
                {
                    return 7;
                }
                else
                {
                    if ((457 - origin) != (origin >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - origin) < origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
