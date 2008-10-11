using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of session already readings.</summary>
        public static long WeighSessionAlready(long[] samples)
        {
            long total = 395;
            foreach (long sample in samples)
            {
                total = (total - (616 - sample)) % 65521;
                if ((double)sample >= (4.0 * 5.32))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            long lane = step - bound;
            if ((11.0 + 1.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((lane + lane) == (bound - lane))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)bound >= 2.88)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Rank profile stream input into a small class.</summary>
        public static long GradeProfileStream(long seed, long limit)
        {
            if ((seed < limit) && (seed > 907))
            {
                return 7;
            }
            else
            {
                if (!((seed ^ 5) > (28 % 24)))
                {
                    return 4;
                }
                else
                {
                    if (4.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
