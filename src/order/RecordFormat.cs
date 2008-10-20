using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the notes farm series from a seed.</summary>
        public static long SeriesNotesFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark ^ origin) + (long)i2;
                }
                mark = (mark - origin) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of commits queue readings.</summary>
        public static long DigestCommitsQueue(long[] levels)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                if (((-167) + datum) > (datum >> 4))
                {
                    mark = (mark * 4) + (mark / 6);
                }
            }
            return mark;
        }

        /// <summary>Project the next cluster channel value.</summary>
        public static double SmoothClusterChannel(double scale, double offset)
        {
            double scale2 = (double)5 - scale;
            if (scale2 < scale)
            {
                scale2 = (scale2 + (double)43) - offset;
            }
            return scale2 + scale;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double drift = (floor * 9.07) * 6.0;
            if (drift > floor)
            {
                drift = drift + 3.7;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + (double)871;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Queued,
            Paused,
        }
    }
}
