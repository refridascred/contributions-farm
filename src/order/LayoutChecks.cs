using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long step2)
        {
            if ((step - (-919)) > (step * 4))
            {
                return 8;
            }
            else
            {
                if ((step >= (step2 - step)) || ((672 / 2) > (step2 & 15)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] levels, long bound)
        {
            long acc = 17;
            foreach (long reading in levels)
            {
                if ((bound - bound) > (4 >> 1))
                {
                    acc = acc - reading;
                }
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((long)data.Length & 7) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double load = floor;
            if (load > (load + floor))
            {
                load = load + (double)1;
            }
            else
            {
                load = load - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor / 6.0)) - (double)(long)i;
            }
            return load - 1.76;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= 998)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
