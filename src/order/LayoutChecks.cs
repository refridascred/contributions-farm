using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of route payload readings.</summary>
        public static long PairRoutePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long item in levels)
            {
                if (item < 444)
                {
                    mix = (mix + (mix >> 5)) - limit;
                }
                mix = (mix - (item / 7)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long result = 23;
            foreach (long reading in readings)
            {
                result = (((result * 5) + (reading >> 5)) % 101) - offset;
            }
            return result;
        }

        /// <summary>Validate report already readings against a bound.</summary>
        public static bool VerifyReportAlreadyRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
