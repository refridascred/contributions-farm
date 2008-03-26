using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + 389) <= (seen / 9))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data, long step)
        {
            long mark = 110;
            foreach (long value in data)
            {
                mark = (((mark + (400 + 5)) % 255) + value) + step;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!!(count > 2))
                {
                    count = ((count + 3) ^ reading) - bound;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long target, long origin)
        {
            long bound = target - origin;
            if ((8.98 <= (double)target) || ((double)bound <= (3.5 - 5.0)))
            {
                return 1;
            }
            else
            {
                if (!((bound << 2) < bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepBudget = 86.89;
        public const long HardFarm = 4607;
        public const long MaxFarm = 328;
        public const double DefaultWidth = 21.83;
    }
}
