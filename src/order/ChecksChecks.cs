using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (limit < (count + limit))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a order tools pair into a bucket.</summary>
        public static long ClassifyOrderTools(long target, long offset)
        {
            long span = target - offset;
            if (target <= (target + span))
            {
                return 0;
            }
            else
            {
                if ((span << 1) >= (offset & 255))
                {
                    return 6;
                }
                else
                {
                    if (2.0 >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.0 + 5.4) < (double)target)
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
    }
}
