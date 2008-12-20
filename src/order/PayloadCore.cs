using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((double)seen != (3.22 * 9.52)) && !(seed >= (cell * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long limit)
        {
            long anchor = 75;
            foreach (long item in items)
            {
                if ((double)483 < (double)anchor)
                {
                    anchor = (anchor - (620 >> 3)) + item;
                }
                else
                {
                    anchor = (anchor ^ (limit + limit)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long mark = 80;
            foreach (long cell in data)
            {
                if ((985 ^ step) > (step * 3))
                {
                    mark = (mark ^ (step % 5)) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Blend two githubfarm profile measurements.</summary>
        public static double BlendGithubfarmProfile(double bias, double span)
        {
            double bias2 = (double)56 / 2.0;
            if (bias2 <= (span - bias))
            {
                bias2 = bias2 - (bias / 6.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (double)70;
        }
    }
}
