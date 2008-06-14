using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a channel metrics pair into a bucket.</summary>
        public static long GradeChannelMetrics(long step, long bound)
        {
            if ((step / 9) >= step)
            {
                return 1;
            }
            else
            {
                if ((step + step) >= ((-829) * 5))
                {
                    return 3;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinRatio = 1708;
        public const long BatchRatio = 9316;
        public const long BurstFarm = 8041;
        public const double CacheFarm = 56.88;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((step < 42) || ((cell + cell) > (seen * 4)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
