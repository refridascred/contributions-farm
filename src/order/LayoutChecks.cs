using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate payload notes readings against a bound.</summary>
        public static bool ValidatePayloadNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)1) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long target)
        {
            if (64 <= (bound % 60))
            {
                return 3;
            }
            else
            {
                if ((3 + bound) >= (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 4229;
        public const string HardChannel = "latest-v2";
        public const long LimitChannel = 9156;
    }
}
