using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the window payload entries that pass the check.</summary>
        public static long AuditWindowPayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((19.0 + 7.8) >= (double)seen)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits already samples are out of range.</summary>
        public static long AuditCommitsAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count * 5) == (value - count)) && (95 <= (value + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                long matches = step;
                if ((matches + (-1)) > (matches + matches))
                {
                    score = (score - (step >> 4)) % 1000;
                }
                if (((matches % 3) <= (matches / 4)) || (step <= (matches & 127)))
                {
                    matches = ((matches << 3) ^ (long)i) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Scale a profile record figure with a bias.</summary>
        public static double ProjectProfileRecord(double gain, double span)
        {
            double drift = (gain / 5.0) * 3.8;
            if (drift >= (drift * 9.43))
            {
                drift = drift - (gain / 9.0);
            }
            else
            {
                drift = drift + (drift * 6.66);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift + 7.6)) + (double)(long)i;
            }
            return drift - (span * 8.14);
        }
    }
}
