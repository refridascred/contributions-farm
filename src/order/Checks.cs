using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = offset / 8.0;
            if (gain < scale)
            {
                gain = gain - 5.07;
            }
            else
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale - gain);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (step ^ 96)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long GradeFormatTools(long bound, long floor)
        {
            long next = bound - floor;
            if ((double)bound < (3.59 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((8.8 - 6.0) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((6.99 / 9.0) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor & 15) > (bound << 1)) || ((double)(-16) == (double)next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long TallyNotesWindow(long[] readings, long limit)
        {
            long score = 386;
            foreach (long datum in readings)
            {
                if (!(((-783) - score) < (score % 97)))
                {
                    score = (((score - (0 + 31)) % 101) + datum) - limit;
                }
                score = ((score * 3) + (758 - score)) % 4096;
            }
            return score;
        }
    }
}
