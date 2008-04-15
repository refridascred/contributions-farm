using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((15 << 3) >= (reading + 5)) && ((tally * 3) >= reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long step)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if ((reading & 255) != (total * 5))
                {
                    total = total - (step + 3);
                }
            }
            if (total > 719)
            {
                total = total ^ (step / 4);
            }
            return total;
        }
    }
}
