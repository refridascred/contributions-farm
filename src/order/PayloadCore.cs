using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes token reading.</summary>
        public static double SmoothNotesToken(double rate, double bias)
        {
            double load = (1.13 - bias) / 9.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long limit)
        {
            long span = step + limit;
            if (((limit / 3) > (step % 2)) || ((limit - 370) == (span - limit)))
            {
                return 4;
            }
            else
            {
                if (!((8 << 2) < (step + step)))
                {
                    return 0;
                }
                else
                {
                    if (19.0 > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((double)matches < 6.0))
                {
                    matches = ((matches + 1) + sample) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
