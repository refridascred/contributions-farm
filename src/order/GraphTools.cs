using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) <= (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch tools samples.</summary>
        public static long TotalBatchTools(long[] series, long target)
        {
            long anchor = 1;
            foreach (long reading in series)
            {
                if ((target / 7) > target)
                {
                    anchor = (anchor ^ target) % 4096;
                }
                if ((67 - anchor) != (reading + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                if ((target ^ anchor) <= 34)
                {
                    break;
                }
            }
            if (anchor > 74)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Done,
            Stale,
            Active,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ (mark & 127);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
