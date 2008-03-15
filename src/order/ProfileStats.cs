using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a record notes figure with a bias.</summary>
        public static double SmoothRecordNotes(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (ratio + 1.7)) + (double)(long)i) + floor;
            }
            return ratio - scale;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target >= (double)2)
            {
                return 1;
            }
            else
            {
                if ((0 - target) > span)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 4) != (floor - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor / 7) != (target / 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long total = -204;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((((total << 2) ^ 553) % 97) + (long)i) - reading;
                }
                total = total ^ (offset >> 1);
            }
            return total;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Active,
            Idle,
            Ready,
        }
    }
}
