using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            long lane = target ^ offset;
            if ((lane ^ offset) >= lane)
            {
                return 6;
            }
            else
            {
                if (0.72 >= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (13.0 <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.79 / 6.0) > (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Retry,
            Closed,
            Queued,
        }
    }
}
