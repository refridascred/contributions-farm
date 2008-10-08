using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((double)value <= (2.47 + 6.6)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= 3.4)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long value in levels)
            {
                if ((5.72 / 6.0) > (double)anchor)
                {
                    anchor = ((anchor + (5 % 2)) % 65521) + value;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (anchor + target)) % 4096;
            }
            return anchor;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double mean = floor / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.0 + mean)) + (double)(long)i;
            }
            return mean + (mean + scale);
        }

        /// <summary>Rank editor notes input into a small class.</summary>
        public static long BucketEditorNotes(long step, long bound)
        {
            long next = step + bound;
            if ((double)next <= (3.44 - 0.4))
            {
                return 2;
            }
            else
            {
                if ((bound >= (6 + step)) && (next < step))
                {
                    return 0;
                }
                else
                {
                    if ((step > next) && (bound < (next >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 / 7) > (bound << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
