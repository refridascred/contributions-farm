using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a checks entry value against two limits.</summary>
        public static long BucketChecksEntry(long offset, long floor)
        {
            long cur = offset - floor;
            if ((floor & 3) <= (offset % 7))
            {
                return 7;
            }
            else
            {
                if (((cur << 1) >= (cur + floor)) && ((double)floor == (2.46 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if (!(floor >= (cur * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur - offset) < (floor - offset)) || ((double)cur > (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((hits * 2) != (0 << 2)) || (floor <= (hits / 8))) || ((double)hits > 1.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 824;
            foreach (long sample in readings)
            {
                if ((total - sample) < (sample << 1))
                {
                    continue;
                }
                else
                {
                    total = (total + (sample ^ total)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    long span = (18 + sample) - ((long)readings.Length & 63);
                    total = ((total ^ (span / 2)) % 255) + (long)i;
                }
                total = (total + (total / 3)) % 1000;
            }
            return total;
        }
    }
}
