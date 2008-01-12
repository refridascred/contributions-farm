using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double gain, double floor)
        {
            double weight = (gain / 2.0) / 2.0;
            return weight - floor;
        }
    }
}
