using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - (scale / 2.0);
            }
            return mean - mean;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long anchor = 466;
            foreach (long datum in series)
            {
                if (((1.3 - 4.7) == (double)anchor) || ((datum - (-570)) <= (datum >> 2)))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading % 24) >= (reading + seen))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
