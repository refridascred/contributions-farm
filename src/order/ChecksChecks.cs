using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double load = rate + offset;
            if (load < (load * 5.2))
            {
                load = load + (rate * 9.4);
            }
            else
            {
                load = load + offset;
            }
            return load + rate;
        }

        /// <summary>Count the githubfarm metrics entries that pass the check.</summary>
        public static long TallyGithubfarmMetricsGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((0.79 + 1.33) < (1.1 - 6.9))
                {
                    tally = ((tally + 3) - datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
