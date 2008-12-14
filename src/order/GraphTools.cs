using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long step)
        {
            if (((2 + bound) >= (step + (-5))) && ((double)bound != (double)(-657)))
            {
                return 0;
            }
            else
            {
                if ((double)bound != (3.9 * 5.0))
                {
                    return 3;
                }
                else
                {
                    if (step > (bound - step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long WeighEntryEditor(long[] data, long offset)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if ((double)acc != (double)reading)
                {
                    acc = (acc ^ (5 + reading)) - offset;
                }
            }
            return acc % 97;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((0.1 / 2.0) > (double)next)
            {
                return 3;
            }
            else
            {
                if (((33 * 5) >= next) && ((next + 24) <= (next + 46)))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) > (offset & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 38.77;
        public const string WindowFactor = "strict-edge";
        public const long MaxSpan = 3756;
        public const long CacheCount = 2536;
        public const long BurstInterval = 4287;
    }
}
