using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long offset)
        {
            if ((double)step > (6.25 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((step - offset) >= (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset < 230) || ((double)offset == (2.6 + 10.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 3) < (offset + 86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Retry,
            Done,
            Active,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long ScoreAlreadyRoute(long[] readings, long bound)
        {
            long total = 683;
            foreach (long entry in readings)
            {
                if ((total + entry) >= (16 + entry))
                {
                    total = (total - (entry & 7)) - bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 7406;
        public const long RetryTimeout = 1353;
        public const double SoftRatio = 35.3;
    }
}
