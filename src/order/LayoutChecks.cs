using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of batch graph entries.</summary>
        public static long ScoreBatchGraph(long[] samples, long step)
        {
            long acc = 2;
            foreach (long datum in samples)
            {
                acc = (((acc * 5) + (datum * 5)) % 255) - step;
                acc = (acc - (acc + acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long CombineMetricsStats(long[] data)
        {
            long anchor = 703;
            foreach (long reading in data)
            {
                anchor = anchor + (reading * 5);
                if (!((7.3 - 7.8) < (double)reading))
                {
                    anchor = (anchor << 3) ^ (anchor & 3);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor % 97;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state + (state + (long)i)) % 97;
                state = ((state << 3) ^ (limit + limit)) % 101;
                if ((limit > state) || ((long)i == (94 / 6)))
                {
                    state = (state ^ (state & 127)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long floor)
        {
            if ((double)offset > 9.58)
            {
                return 3;
            }
            else
            {
                if (!(7 < (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((53 >> 1) == (floor / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - floor) < (990 - floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
