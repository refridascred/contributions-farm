using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a order format pair into a bucket.</summary>
        public static long GradeOrderFormat(long origin, long step)
        {
            if (!((origin + 4) < origin))
            {
                return 1;
            }
            else
            {
                if ((step >= (origin - step)) && ((double)origin > (6.2 - 9.99)))
                {
                    return 6;
                }
                else
                {
                    if ((0.3 + 7.17) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                if ((anchor << 2) < entry)
                {
                    anchor = ((anchor * 3) + (offset >> 3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
