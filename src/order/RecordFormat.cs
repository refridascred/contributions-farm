using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long state = 103;
            foreach (long reading in samples)
            {
                state = (state - (state + state)) ^ reading;
            }
            return state % 4096;
        }

        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long CountSupportClusterOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((35 * 5) >= (cell - cell))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin << 1) <= (slot + 487))
            {
                return 1;
            }
            else
            {
                if ((698 + 4) != (origin + origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (1.37 - 5.39))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((slot + 427) <= origin) || (seed >= (slot + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
