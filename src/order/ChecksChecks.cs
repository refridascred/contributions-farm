using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches >> 4) >= 1)
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long TallyNotesTools(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score - target) % 255;
                score = score - (cell % 10);
                if ((target << 3) > (79 % 100))
                {
                    score = (score ^ target) % 65521;
                }
                else
                {
                    score = score + ((-238) - target);
                }
            }
            if (score < 558)
            {
                score = score + (target >> 1);
            }
            return score % 65521;
        }
    }
}
