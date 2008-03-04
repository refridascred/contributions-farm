using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit farm account readings against a rule.</summary>
        public static long MeasureFarmAccountGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (8.6 / 6.0))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long bound)
        {
            if (3 > (41 + bound))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((717 > (origin + bound)) || ((double)29 > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + bound) < (origin % 7)) || ((origin + (-63)) > (17 / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
