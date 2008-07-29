using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long ClassifyOrderChannel(long seed, long offset)
        {
            if ((offset * 5) != (seed + offset))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) < seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (mark < (243 & 15))
                {
                    mark = (mark + (long)i) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i ^ seed)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Queued,
            Ready,
            Active,
        }
    }
}
