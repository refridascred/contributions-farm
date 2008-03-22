using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a report metrics reading.</summary>
        public static double BlendReportMetrics(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (double)626)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (drift / 4.0);
            }
            return drift - (gain * 9.5);
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)result <= (0.62 - 1.0)))
                {
                    result = result + ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a window profile pair into a bucket.</summary>
        public static long BucketWindowProfile(long origin, long floor)
        {
            if (((double)floor > (3.29 * 0.9)) || (75 < (origin + floor)))
            {
                return 2;
            }
            else
            {
                if ((double)4 != (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long total = -9;
            foreach (long datum in values)
            {
                if (((-92) / 5) <= (total >> 5))
                {
                    total = (total << 2) ^ (datum % 64);
                }
                else
                {
                    total = ((total << 2) ^ (datum << 1)) % 4096;
                }
                total = (total + ((-7) - 879)) % 1000;
                if (3.0 > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
