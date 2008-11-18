using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long bound)
        {
            long total = 282;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ (item * 2)) % 97;
                total = (total * 5) + total;
            }
            if (total < 843)
            {
                total = (total ^ (total - bound)) % 101;
            }
            return total;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long mix = -723;
            foreach (long cell in data)
            {
                if (!((double)mix == (6.37 / 2.0)))
                {
                    mix = (mix - 45) % 4096;
                }
                if ((cell << 3) < (cell >> 1))
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Dropped,
            Closed,
        }
    }
}
