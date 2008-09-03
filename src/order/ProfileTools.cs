using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((floor % 3) == (value * 3)) || ((8.22 / 2.0) == (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 4230;
        public const double DefaultRoute = 74.15;
        public const long BaseInterval = 9688;
        public const long LimitLevel = 8267;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (bound <= (844 / 2))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm format value against two limits.</summary>
        public static long GradeGithubfarmFormat(long floor, long limit)
        {
            long span = floor + limit;
            if (!((span >> 3) >= (limit + 647)))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) < (38 + span))
                {
                    return 6;
                }
                else
                {
                    if (((limit << 3) <= (311 << 2)) && ((floor / 7) <= span))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 5) >= (limit & 127))
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
        }
    }
}
