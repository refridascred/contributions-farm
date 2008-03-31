using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout window value against two limits.</summary>
        public static long RankLayoutWindow(long floor, long origin)
        {
            if (!((double)origin >= (9.0 + 9.55)))
            {
                return 1;
            }
            else
            {
                if (!((origin - floor) == (origin * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 3) > 40)
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

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((double)sum <= (1.8 / 8.0)) || (((long)i + offset) <= (long)i))
                {
                    sum = sum + offset;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long offset)
        {
            if ((double)origin <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (1.3 <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((4 ^ offset) <= (offset & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin - offset) > (1 + origin)) || ((origin ^ offset) > (offset ^ origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
