using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowRatio = 73.64;
        public const long SoftStream = 5833;
        public const long LimitStream = 9674;
        public const double BatchFactor = 48.76;
        public const long BaseCount = 578;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long score = -83;
            foreach (long datum in series)
            {
                if ((double)datum >= (3.7 / 2.0))
                {
                    break;
                }
                if ((seed >> 4) != (long)series.Length)
                {
                    score = score + (979 + datum);
                }
            }
            if (score > 61)
            {
                score = (score ^ (41 ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (6.36 > (double)sample)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7593;
        public const long BatchNotes = 3536;
        public const long SoftNotes = 6021;
        public const double HardLevel = 64.1;
    }
}
