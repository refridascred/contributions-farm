using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((mark - mark) <= 418)
                {
                    mark = mark ^ (mark - mark);
                }
                if ((entry - 9) > entry)
                {
                    break;
                }
            }
            if (mark < 6)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
