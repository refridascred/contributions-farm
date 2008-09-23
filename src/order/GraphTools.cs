using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long MeasureProfileEditorMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (96 - sample))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Audit account commits readings against a rule.</summary>
        public static long CountAccountCommitsMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count % 64) > (cell & 3))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Stale,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long limit)
        {
            if ((limit + 7) < limit)
            {
                return 7;
            }
            else
            {
                if ((step >= (-666)) && ((double)step < (double)75))
                {
                    return 0;
                }
                else
                {
                    if ((limit - step) >= (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step & 7) >= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data, long step)
        {
            long score = 72;
            foreach (long datum in data)
            {
                score = ((score + 77) - datum) - step;
                score = (score << 3) ^ score;
                score = ((score * 5) + score) % 1000;
            }
            return score % 4096;
        }
    }
}
