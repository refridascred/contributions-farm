using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ ((long)i - (long)i)) % 101;
                anchor = anchor + (step & 15);
                anchor = ((anchor << 3) ^ (long)i) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every metrics order entry stays within the limit.</summary>
        public static bool VerifyMetricsOrderLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = -59;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark ^ mark) + (long)i;
                }
                mark = mark - ((-24) ^ 479);
                if ((cell - mark) >= (mark * 4))
                {
                    mark = (mark * 5) + (mark & 15);
                }
                if (!(8.82 < (double)mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
