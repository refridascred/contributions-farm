using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((limit >= (limit * 5)) || ((limit + limit) != (3 - (-99)))) || ((seen - seen) != (limit / 4)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long step)
        {
            if (52 >= (step / 9))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) <= ((-3) >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((4.94 - 3.0) >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double load = (double)(293 & 15);
            if (load > ratio)
            {
                load = (load - (0.67 + 1.6)) + bias;
            }
            return load + ratio;
        }
    }
}
