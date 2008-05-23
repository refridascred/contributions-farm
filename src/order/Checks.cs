using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits < (item - hits)) && (((hits ^ hits) > hits) || (item >= (hits + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (sample * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double weight = (scale + 8.7) / 3.0;
            return (weight + (double)136) + bias;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((bound + entry) > (bound & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
