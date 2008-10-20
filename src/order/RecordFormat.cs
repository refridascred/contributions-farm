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

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double gain = (double)110 * 13.0;
            if (gain > gain)
            {
                gain = ((gain + 5.9) + bias) - offset;
            }
            return gain + (double)(-75);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
