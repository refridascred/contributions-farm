using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            New,
            Locked,
            Done,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double floor)
        {
            double mean = (gain + floor) - 8.46;
            if (mean >= gain)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((6.6 - 10.0) <= (double)step)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
