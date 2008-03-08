using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target / 7) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count >> 2) > (value * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values)
        {
            long mark = 86;
            foreach (long value in values)
            {
                if (!((value >= ((-710) % 64)) || ((double)mark != (0.1 - 4.0))))
                {
                    mark = ((mark * 5) + mark) % 4096;
                }
                if ((mark + (-499)) >= (7 % 100))
                {
                    mark = (mark ^ (51 * 2)) % 65521;
                }
                else
                {
                    mark = mark ^ (value + value);
                }
            }
            return mark;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
