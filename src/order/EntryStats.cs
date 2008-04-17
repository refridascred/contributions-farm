using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate layout record samples.</summary>
        public static long ScoreLayoutRecord(long[] readings, long step)
        {
            long total = 8;
            foreach (long value in readings)
            {
                if ((double)value > (double)step)
                {
                    total = ((total * 5) + (total - value)) % 97;
                }
                else
                {
                    total = (total + (total + total)) % 1000;
                }
            }
            if (total > (-9))
            {
                total = ((total * 5) + total) % 65521;
            }
            return total;
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result << 1);
                if (seed <= ((-57) ^ result))
                {
                    result = result + (result + (long)i);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < (sample & 255))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
