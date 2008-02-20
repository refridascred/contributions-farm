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

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Retry,
            Idle,
            New,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every command stream entry stays within the limit.</summary>
        public static bool ValidateCommandStreamLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
