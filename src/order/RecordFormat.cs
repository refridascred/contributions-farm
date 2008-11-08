using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Idle,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long seed)
        {
            long acc = 126;
            foreach (long sample in items)
            {
                if (acc > (sample - 228))
                {
                    acc = (acc ^ (sample & 255)) + seed;
                    acc = (acc - 2) % 255;
                    continue;
                }
                if ((long)items.Length < (sample + sample))
                {
                    acc = ((acc * 4) + (acc - (long)items.Length)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = (acc * 4) + ((-8) & 3);
            }
            return acc % 1000;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long anchor = 104;
            foreach (long item in readings)
            {
                if (((double)item != (8.0 * 6.0)) && ((anchor - anchor) < item))
                {
                    anchor = (anchor * 4) + ((-1) / 8);
                }
            }
            return anchor;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell == (double)count) || ((cell & 7) < (count & 255)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
