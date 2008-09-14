using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (928 <= (cell & 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric command readings.</summary>
        public static long DigestMetricCommand(long[] levels)
        {
            long mark = 665;
            foreach (long entry in levels)
            {
                if (((entry - 41) <= mark) && ((entry << 2) == (589 & 255)))
                {
                    mark = mark - (mark ^ mark);
                }
            }
            if (mark < 764)
            {
                mark = (mark ^ (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading > 5.4)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
