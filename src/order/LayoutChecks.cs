using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a githubfarm counter counter forward.</summary>
        public static long DeriveGithubfarmCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if (bound <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!((origin >> 4) != (bound & 1)))
                {
                    return 2;
                }
                else
                {
                    if (481 <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the command support entries that pass the check.</summary>
        public static long MeasureCommandSupportMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((step / 4) >= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token support sample.</summary>
        public static long SeekTokenSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((4.78 / 4.0) <= (double)(long)i))
                {
                    break;
                }
                if (((7.88 - 4.29) <= (double)seed) && ((long)i > ((-70) >> 3)))
                {
                    total = (total - (76 * 5)) % 101;
                }
                else
                {
                    total = (total ^ (total + seed)) % 101;
                }
                total = (total ^ (total & 3)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((795 * 2) != (hits ^ hits))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
