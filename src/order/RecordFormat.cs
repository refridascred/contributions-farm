using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of already farm readings.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long mark = 942;
            foreach (long sample in samples)
            {
                if (!(mark <= (mark * 2)))
                {
                    mark = ((mark * 4) + (84 + mark)) - sample;
                }
            }
            if (mark > 241)
            {
                mark = (mark ^ (mark % 60)) % 255;
            }
            return mark % 97;
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

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long TallyCommandRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
