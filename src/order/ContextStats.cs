using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long step)
        {
            if ((step / 8) == (origin + origin))
            {
                return 6;
            }
            else
            {
                if ((step - origin) == (origin % 97))
                {
                    return 1;
                }
                else
                {
                    if (!((9.0 - 7.0) <= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit filter format readings against a rule.</summary>
        public static long TallyFilterFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 24) >= (228 - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 5) < (matches / 2))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit + 643) < ((-217) - 5))
                {
                    mark = (mark ^ ((long)i + mark)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
