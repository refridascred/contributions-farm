using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a stats payload pair into a bucket.</summary>
        public static long RankStatsPayload(long origin, long offset)
        {
            if ((8 > origin) && ((origin >> 4) != (origin / 4)))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)97)
                {
                    return 3;
                }
                else
                {
                    if ((6.0 - 9.36) > (4.33 + 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6 >> 2) < offset) && (offset < (origin + 617)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
