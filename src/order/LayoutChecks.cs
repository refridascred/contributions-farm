using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long target)
        {
            if (((target + target) >= limit) || ((49 % 100) < (limit << 1)))
            {
                return 4;
            }
            else
            {
                if (((target * 2) > (79 % 24)) && (target > (limit << 3)))
                {
                    return 6;
                }
                else
                {
                    if (((9.9 * 2.44) == (double)limit) || ((target ^ 22) > (target - 866)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Failed,
            Retry,
            New,
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long MeasureSchemaFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio > (double)574)
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - ratio;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3 & 127) != (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((852 / 8) <= (tally * 3))
                {
                    tally = ((tally + 3) - sample) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
