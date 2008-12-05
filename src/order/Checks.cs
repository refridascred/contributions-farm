using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a entry commits value against two limits.</summary>
        public static long ClassifyEntryCommits(long seed, long step)
        {
            if ((step - seed) > (step & 1))
            {
                return 4;
            }
            else
            {
                if (((7.0 + 20.0) < (double)step) && (seed >= (step - 6)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (5.57 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step >> 4) >= step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long TallySessionPayloadOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((reading ^ reading) < (tally ^ (-72))) && ((tally ^ limit) < reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long target, long limit)
        {
            long edge = target + limit;
            if (!((target - limit) > (4 + edge)))
            {
                return 2;
            }
            else
            {
                if ((edge + limit) <= (target / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)target >= (0.09 - 1.28))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + 3) < (limit + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Pending,
            Closed,
            Locked,
            Done,
        }
    }
}
