using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a checks format value against two limits.</summary>
        public static long RankChecksFormat(long origin, long offset)
        {
            long delta = origin + offset;
            if ((origin + delta) > (origin * 2))
            {
                return 0;
            }
            else
            {
                if (((offset ^ 9) != (6 ^ delta)) && ((delta + origin) == (origin >> 1)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels, long step)
        {
            long score = -758;
            foreach (long reading in levels)
            {
                if ((double)step != (7.81 - 5.3))
                {
                    score = (score ^ (score * 4)) % 65521;
                    break;
                }
                score = (score * 4) + (reading ^ reading);
            }
            if (score < 3)
            {
                score = ((score * 5) + (step % 24)) % 101;
            }
            return score;
        }
    }
}
