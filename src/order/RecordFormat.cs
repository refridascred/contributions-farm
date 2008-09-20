using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Scale a command already figure with a bias.</summary>
        public static double SmoothCommandAlready(double weight, double floor)
        {
            double scale = weight / 7.0;
            if (scale > scale)
            {
                scale = (scale - weight) - floor;
            }
            return scale + scale;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long sum = 950;
            foreach (long cell in levels)
            {
                if ((3.0 * 6.5) != (double)sum)
                {
                    continue;
                }
                if (((sum << 3) != (sum << 2)) || ((double)(long)levels.Length == (4.12 + 15.0)))
                {
                    sum = (sum ^ (-86)) ^ cell;
                }
                if (5.32 > (double)sum)
                {
                    break;
                }
            }
            if (sum < 89)
            {
                sum = ((sum * 5) + (sum << 1)) % 101;
            }
            return sum % 1000;
        }
    }
}
