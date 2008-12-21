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

        /// <summary>Match up window notes samples.</summary>
        public static long CompareWindowNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
