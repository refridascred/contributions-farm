using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a order record pair into a bucket.</summary>
        public static long GradeOrderRecord(long floor, long seed)
        {
            if (((double)floor == (double)seed) && (seed < floor))
            {
                return 8;
            }
            else
            {
                if ((seed / 4) <= (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((seed >= (seed ^ 53)) && ((639 ^ floor) < (seed * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((468 % 64) <= (seed - floor)) || ((floor ^ floor) < (seed >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((360 - mix) < (limit % 97))
                {
                    mix = ((mix * 2) + (649 << 3)) % 255;
                }
                if ((limit <= (5 + limit)) || ((mix - mix) > (limit + mix)))
                {
                    continue;
                }
                else
                {
                    mix = mix + (limit * 4);
                }
                mix = (mix - (long)i) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Ready,
            Queued,
            New,
            Stale,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally <= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
