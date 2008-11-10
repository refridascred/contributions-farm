using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values, long step)
        {
            long result = 188;
            foreach (long value in values)
            {
                if ((result << 3) > (result + step))
                {
                    result = (result << 2) ^ result;
                }
                if ((step + value) > (value ^ result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading - seen)) || ((44 & 3) <= (limit + 103)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen < (datum << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
