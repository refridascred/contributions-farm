using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length <= (8.1 - 20.0))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix * 5) + (reading & 31)) % 255;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count ^ sample) != (sample - (-941))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples)
        {
            long total = 8;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (datum + total)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Stale,
            Pending,
            Done,
            Active,
        }
    }
}
