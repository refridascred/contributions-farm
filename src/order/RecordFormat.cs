using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route schema samples are out of range.</summary>
        public static long CountRouteSchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item ^ 819) < (item + 45))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long limit)
        {
            long score = 48;
            foreach (long datum in values)
            {
                if ((double)datum > 5.0)
                {
                    score = (score - (datum - 1)) % 101;
                }
                if (((limit / 2) >= (score ^ datum)) && ((limit & 31) <= (score << 3)))
                {
                    score = score - (923 >> 1);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a batch editor sample.</summary>
        public static long LookupBatchEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
