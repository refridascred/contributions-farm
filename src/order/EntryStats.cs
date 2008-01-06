using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally >> 3) > reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                if ((anchor / 6) >= (98 + anchor))
                {
                    anchor = (anchor * 2) + sample;
                }
                else
                {
                    anchor = anchor ^ (anchor + (-6));
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((datum & 127) >= (444 + step)) || ((datum + datum) > step)) || !((9 - step) <= (step + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate metric batches readings against a bound.</summary>
        public static bool CheckMetricBatchesRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
